using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace lab12
{
    public class AYPFileManager
    {
        public static void MoveFiles(string? path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            if (!Directory.Exists(path))
                return;
            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            string generalPath = path;
            path += @"\\AYPInspect\";
            Directory.CreateDirectory(path);
            path += @"dirinfo.txt";

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine("Directories: ");
                foreach (var s in dirs)
                    sw.WriteLine(s);
                sw.WriteLine("Files: ");
                foreach (var s in files)
                    sw.WriteLine(s);
            }
            generalPath += @"\\newName.txt";
            if (File.Exists(generalPath))
                File.Delete(generalPath);

            File.Copy(path, generalPath);
            File.Delete(path);
        }

        public static void MoveDirectoriesByExtension(string? path, string extension)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            if (!Directory.Exists(path))
                return;

            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles().Where(s => s.Extension == extension).ToArray();
            string generalPath = path;
            path += @"\\AYPFiles/";
            Directory.CreateDirectory(path);
            foreach (var f in files)
            {
                if (File.Exists(path))
                    File.Delete(path);
                File.Move(f.FullName, path + f.Name);
            }
            generalPath += @"\\AYPInspect\Files";
            if (Directory.Exists(generalPath))
                Directory.Delete(generalPath, true);
            Directory.Move(path, generalPath);
        }

        public static void ToZip(string? path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            string generalPath = path + @"\\AYPInspect\Files";
            path += @"\\AYPInspect\Files";
            DirectoryInfo directory = new DirectoryInfo(generalPath);
            var files = directory.GetFiles();
            path += @"Files.zip";
            using (System.IO.FileStream zipToOpen = new System.IO.FileStream(path, System.IO.FileMode.OpenOrCreate))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    foreach (var f in files)
                        archive.CreateEntryFromFile(f.FullName, f.Name);
                }
            }
        }
        public static void FromZip(string? path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            string generalpath = path + @"\\AYPInspect\Fromzip";
            path += @"\\AYPInspect\Files";
            path += @"Files.zip";
            if (Directory.Exists(generalpath))
                Directory.Delete(generalpath, true);
            ZipFile.ExtractToDirectory(path, generalpath);

        }
    }
}
