using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    public class DKAFileManager
    {
        public static void GetAllDirsAndFilesOfDisk(string diskName)
        {
            var direct =  DriveInfo.GetDrives();

            if (direct.Any( drive => drive.Name == diskName))
            {

                var dir = new DirectoryInfo(@"G:\Программы малышей\ЛабораторныеРаботы\OOP\laba12\laba12");
                if (dir.GetDirectories("DKAInspect").Length == 0)
                {

                    var subDir = dir.CreateSubdirectory("DKAInspect");
                    var dr = new DirectoryInfo(diskName);

                    using (var file = new StreamWriter(subDir.FullName + "\\" + "DKADirInfo.txt"))
                    {
                        file.WriteLine("----------Directory----------");
                        foreach (var d in dr.GetDirectories())
                            file.WriteLine($"{d.Name}");
                        file.WriteLine("-------------------------------");

                        file.WriteLine("----------Files----------");
                        foreach (var d in dr.GetFiles())
                            file.WriteLine($"{d.Name}");
                        file.WriteLine("-------------------------");
                    }
                    var dirInfo = new FileInfo(subDir.FullName + @"\" + "DKADirInfo.txt");
                    dirInfo.CopyTo(subDir.FullName + @"\" + "DKADirInfoCOPY.txt");
                    dirInfo.Delete();
                }
            }

            DKALog.WriteToLog("DKAFileManager.GetAllDirsAndFilesOfDisk()", "", diskName);

        }

        public static void GetAllFilesWithExtension(string dirPath, string extension)
        {
            var directory = new DirectoryInfo(dirPath);
            if (directory.Exists)
            {
                var temp = new DirectoryInfo(@"G:\Программы малышей\ЛабораторныеРаботы\OOP\laba12\laba12");
                if (temp.GetDirectories("DKAInspect")[0].GetDirectories("DKAFiles").Length == 0)
                {
                    var files = temp.CreateSubdirectory("DKAFiles");

                    foreach (var file in directory.GetFiles($"*{extension}"))
                        file.CopyTo(files.FullName + @"\" + file.Name);

                    files.MoveTo(temp.GetDirectories("DKAInspect")[0].FullName + "\\DKAFiles");
                }
            }

            DKALog.WriteToLog("DKAFileManager.GetAllFilesWithExtension()", "", dirPath);
        }
        public static void CreateZip(string dir)
        {
            const string zipName = @"G:\Программы малышей\ЛабораторныеРаботы\OOP\laba12\laba12\DKAInspect\DKAFiles.zip";
            if (new DirectoryInfo(@"G:\Программы малышей\ЛабораторныеРаботы\OOP\laba12\laba12\DKAInspect").GetFiles("*.zip").Length == 0)
            {
                ZipFile.CreateFromDirectory(dir, zipName);
                var direct = new DirectoryInfo(dir);
                foreach (var innerFile in direct.GetFiles())
                    innerFile.Delete();
                direct.Delete();
                ZipFile.ExtractToDirectory(zipName, dir);
            }

            DKALog.WriteToLog("DKAFileManager.CreateZip()", "", dir);
        }

    }
}
