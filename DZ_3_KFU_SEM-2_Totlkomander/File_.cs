using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_KFU_SEM_2_Totlkomander
{
    internal class File_
    {
        internal string Name;
        internal string Path;
        internal string Ext;
        internal string WriteTime;
        internal string Size;
        internal Image Image;
        public File_(string name, string path, string ext, Image image, string writeTime, string size)
        {
            Name = name;
            Path = path;
            Image = image;
            Ext = ext;
            WriteTime = writeTime;
            Size = size;
        }
    }
}
