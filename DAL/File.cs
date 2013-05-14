using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrazyTechGuys.Filetables.DAL
{
    public class File
    {
        public Guid ID { get; set; }
        public byte[] Stream { get; set; }
        public string Name { get; set; }
        public Directory Directory { get; set; }
        public string Extension { get; set; }
        public int Size { get; set; }
        public DateTime Creation { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime LastAccess { get; set; }
        public bool isHidden { get; set; }
        public bool isReadOnly { get; set; }
        public bool isSystem { get; set; }


    }

    public class Directory
    {
        public string Name { get; set; }
        public bool HasChild { get; set; }
        public string Parent { get; set; }

    }
}
