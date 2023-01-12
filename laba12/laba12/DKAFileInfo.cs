﻿
namespace laba12
{
    public class DKAFileInfo
    {
        public static void GetFileInfo(string file)
        {
            Console.WriteLine("********************************");
            var fileInfo = new FileInfo(file);
            if (!fileInfo.Exists)
            {
                System.Console.WriteLine("File Wasn't Found");
                return;
            }

            Console.WriteLine($"Path: {fileInfo.FullName}");
            Console.WriteLine($"Length: {fileInfo.Length} byte");
            Console.WriteLine($"Name: {fileInfo.Name}");
            Console.WriteLine($"Extension: {fileInfo.Extension}");
            Console.WriteLine($"Creation Time: {fileInfo.CreationTime}");
            Console.WriteLine("********************************\n");

            DKALog.WriteToLog("DKAFileInfo.GetFileInfo()", fileInfo.Name, fileInfo.FullName);

        }

    }
}