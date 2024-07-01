using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace PES5_WE9_LE_BannerRelinker
{
    public class PESFolder
    {
        const uint HEADER_SIZE = 0x20;
        const uint MAGIC_NUMBER = 0x00000600;
        uint Size;
        uint TotalFiles;
        uint FilesOffsetPointer;
        public List<byte[]> Files = new List<byte[]> { };
        public PESFolder(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new ArgumentException($"The file {filePath} doesn't exist");
            }
            byte[] bytes = File.ReadAllBytes(filePath);
            FromBytes(bytes);
        }

        private void FromBytes(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            using (BinaryReader br = new BinaryReader(ms))
            {
                uint magicNumber = br.ReadUInt32();
                if (magicNumber != MAGIC_NUMBER)
                {
                    throw new ArgumentException($"This is not a PES Folder!");
                }
                Size = br.ReadUInt32();
                ms.Seek(HEADER_SIZE, SeekOrigin.Begin);

                TotalFiles = br.ReadUInt32();
                FilesOffsetPointer = br.ReadUInt32();

                ms.Seek(HEADER_SIZE + FilesOffsetPointer, SeekOrigin.Begin);

                uint[] filesOffsets = new uint[TotalFiles];

                for (int i = 0; i < TotalFiles; i++)
                {
                    filesOffsets[i] = br.ReadUInt32();
                }
                uint[] sortedValues = filesOffsets.OrderBy(v => v).ToArray();

                foreach (uint offset in filesOffsets)
                {
                    if (offset == 0) 
                    {
                        Files.Add(new byte[0]);
                        continue;
                    }
                    uint end = Size;
                    
                    int index = Array.IndexOf(sortedValues, offset);
                    if (index < filesOffsets.Length - 1) 
                    {
                        // if is not the last file, then get the next file offset
                        end = sortedValues[index + 1];
                    }
                    uint fileSize = end - offset;
                    ms.Seek(HEADER_SIZE + offset, SeekOrigin.Begin);
                    byte[] file = br.ReadBytes((int)fileSize);
                    Files.Add(file);
                }
            }
        }

        public PESFolder(byte[] bytes) 
        {
            FromBytes(bytes);
        }
        public byte[] ToBytes()
        {
            using (MemoryStream ms = new MemoryStream())
            using (BinaryWriter bw = new BinaryWriter(ms))
            {
                TotalFiles = (uint)Files.Count;
                bw.Write(MAGIC_NUMBER);
                bw.Write(new byte[28]);
                bw.Write(TotalFiles);
                bw.Write(FilesOffsetPointer);
                bw.Write(new byte[TotalFiles * 4]);

                byte[] zeroPadding = Utils.PadWithZeros((int)ms.Position);
                bw.Write(zeroPadding);

                for (int i = 0; i < TotalFiles; i++)
                {
                    uint offset = (uint)ms.Position;
                    ms.Seek(HEADER_SIZE + FilesOffsetPointer + i * 4, SeekOrigin.Begin);
                    bw.Write(offset - HEADER_SIZE);
                    ms.Seek(offset, SeekOrigin.Begin);
                    bw.Write(Files[i]);
                }
                Size = (uint)ms.Position - HEADER_SIZE;
                ms.Seek(4, SeekOrigin.Begin);
                bw.Write(Size);
                return ms.ToArray();
            }
        }
        public void ToFile(string path)
        {
            byte[] data = ToBytes();
            File.WriteAllBytes(path, data);
        }
    }
}
