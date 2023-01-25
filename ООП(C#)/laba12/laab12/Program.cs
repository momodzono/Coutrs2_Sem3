using System;
namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\C#\laab12";

            Console.WriteLine(AYPDiskInfo.GetDiskInfo());
            AYPLog.Write("GetDiskInfo:");
            AYPLog.Write(AYPDiskInfo.GetDiskInfo());
            AYPLog.Write("Session - " + DateTime.Now.ToString() + '\n');

            Console.WriteLine(AYPFileInfo.GetFileInfo());
            AYPLog.Write("GetFileInfo:");
            AYPLog.Write(AYPFileInfo.GetFileInfo());

            Console.WriteLine(AYPDirInfo.GetDirInfo());
            AYPLog.Write("GetDirInfo:");
            AYPLog.Write(AYPDirInfo.GetDirInfo());

            AYPFileManager.MoveFiles(path);
            AYPFileManager.MoveDirectoriesByExtension(path, ".js");
            AYPFileManager.ToZip(path);
            AYPFileManager.FromZip(path);

            Console.WriteLine("============= FROM FILE ==============");
            Console.WriteLine($"============= COUNT: {AYPLog.GetRecordCount()}================");
            Console.WriteLine("======================================\n");
            AYPLog.GetInfoByDay("14.11.2022", 10, 13, "GetFileInfo");

            AYPLog.Del(DateTime.Now.ToShortTimeString().ToString());

            AYPLog.fw.Close();
        }
    }
}