using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab12
{
    public class AYPDirInfo
    {
        private const string path = @"D:\C#";
        public static string GetDirInfo()
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            var dirInf = new DirectoryInfo(path);
            string str = "";

            str += "Путь:" + dirInf.FullName + '\n';
            str += "Количество файлов " + dirInf.GetFiles().Length + '\n';
            str += "Количестве поддиректориев " + dirInf.GetDirectories().Length + '\n';                     //папки
            str += "Список родительских директориев " + dirInf.Parent + '\n';
            str += "Дата создания " + dirInf.CreationTime + '\n';
            return str;
        }
    }
}
