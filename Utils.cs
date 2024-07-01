using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace PES5_WE9_LE_BannerRelinker
{
    public static class Utils
    {
        [DllImport("zlib1.dll", EntryPoint = "compress2", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int CompressByteArray(byte[] dest, ref uint destLen, byte[] src, uint srcLen, int level);

        [DllImport("zlib1.dll", EntryPoint = "uncompress", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UncompressByteArray(byte[] dest, ref uint destLen, byte[] src, uint srcLen);
        static uint GetMaxCompressedLen(uint nLenSrc)
        {
            uint n16kBlocks = (nLenSrc + 16383) / 16384; // round up any fraction of a block
            return (nLenSrc + 6 + (n16kBlocks * 5));
        }
        public static byte[] Unzlib(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            using (BinaryReader reader = new BinaryReader(ms))
            {
                uint magicNumber = reader.ReadUInt32();
                if (magicNumber != 0x00010600 && magicNumber != 0x00010000)
                {
                    throw new ArgumentException($"Is not a zlib file!");
                }
                uint compressSize = reader.ReadUInt32();
                uint decompressSize = reader.ReadUInt32();
                reader.ReadBytes(20);
                byte[] compressData = reader.ReadBytes((int)compressSize);
                byte[] decompressData = new byte[decompressSize];
                int result = UncompressByteArray(decompressData, ref decompressSize, compressData, compressSize);
                if (result < 0)
                {
                    Console.WriteLine($"Error when trying to decompress code error: {result}");
                }

                //if (result != 0 && result != -5)
                //{
                //    throw new Exception($"An error has ocurred while trying to decompress {filePath}");
                //}
                return decompressData;
            }
        }
        public static byte[] PadWithZeros(byte[] data)
        {
            int size = data.Length;
            int padNumber = 16 - (size % 16);

            if (padNumber == 16)
            {
                return data;
            }

            byte[] paddedData = new byte[size + padNumber];
            Array.Copy(data, paddedData, size);

            return paddedData;
        }

        public static byte[] PadWithZeros(int pos)
        {
            int padNumber = 16 - (pos % 16);
            if (padNumber == 16)
            {
                padNumber = 0;
            }
            byte[] paddedData = new byte[padNumber];

            return paddedData;
        }
        public static byte[] PESZlib(byte[] data, uint magicNumber)
        {
            using (MemoryStream ms = new MemoryStream())
            using (BinaryWriter bw = new BinaryWriter(ms))
            {
                uint compressLen = GetMaxCompressedLen((uint)data.Length);
                byte[] compressData = new byte[compressLen];
                CompressByteArray(compressData, ref compressLen, data, (uint)data.Length, 9);

                // remove probable extra zeros
                
                int lastIndex = -1;
                for (int i = compressData.Length - 1; i >= 0; i--)
                {
                    if (compressData[i] != 0)
                    {
                        lastIndex = i;
                        break;
                    }
                }

                byte[] newcompressData = new byte[lastIndex + 1];
                Array.Copy(compressData, newcompressData, lastIndex + 1);
                newcompressData = PadWithZeros(newcompressData);

                bw.Write(magicNumber);
                bw.Write((uint)newcompressData.Length);
                bw.Write((uint)data.Length);
                bw.Write(new byte[0x14]);
                bw.Write(newcompressData);
                return ms.ToArray();
            }
        }
        public static List<Color> GetSupporterColours()
        {

            List<Color> colourList = new List<Color>();
            string[] colours = new string[]
            {
                "Black",
                "Blue",
                "Red",
                "Pink",
                "Lime",
                "LightBlue",
                "Yellow",
                "White",
                "Gray",
                "Navy",
                "Maroon",
                "Purple",
                "Green",
                "Gold",
                "Orange",
            };
            foreach (var colour in colours)
            {
                Color color = Color.FromName(colour);
                colourList.Add(color);
            }
            return colourList;
        }
        public static void WriteUInt16(byte[] buffer, int offset, ushort value)
        {
            buffer[offset] = (byte)value;
            buffer[offset + 1] = (byte)(value >> 8);
        }
    }
}
