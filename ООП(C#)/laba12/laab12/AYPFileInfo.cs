using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab12
{
    public class AYPFileInfo
    {
        private const string path = @"D:\C#\laab12\AYPlog.txt";
        public static string GetFileInfo()
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            var fileInf = new FileInfo(path);
            string str = "";

            str += "Путь:" + fileInf.DirectoryName + '\n';
            str += "Размер " + fileInf.Length + '\n';
            str += "Дата создания " + fileInf.CreationTime + '\n';
            str += "Дата последнего изменения " + fileInf.LastWriteTime + '\n';
            str += "Атрибуты " + fileInf.Attributes + '\n';
            return str;
        }

    }
}
