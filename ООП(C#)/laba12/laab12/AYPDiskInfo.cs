using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab12
{
    public class AYPDiskInfo
    {
        public static string GetDiskInfo()
        {
            var AllDrivers = DriveInfo.GetDrives();
            string str = "";
            foreach (var d in AllDrivers)
            {
                str += "Имя диска: " + d.Name + '\n';
                str += "Дисковое пространство: " + d.TotalSize.ToString() + '\n';
                str += "Свободное место на диске:" + d.TotalFreeSpace.ToString() + '\n';
                str += "Метка диска: " + d.VolumeLabel;
            }
            return str;
        }
    }
}
