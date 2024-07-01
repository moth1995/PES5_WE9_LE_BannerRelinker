using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PES5_WE9_LE_BannerRelinker
{
    public class Team
    {
        public ushort Id;
        public string Name;
        public ushort BannerFile;
        public ushort BannerTextureId;
        public byte SuppColourMain;
        public byte SuppColourSec;
        public byte stadId;

        public Team(ushort id, string name) 
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
