

namespace laba12
{

    class Program
    {
        public static void Main()
        {

            // 2 
            DKADiskInfo.DriveFreeMemory(@"C:\");
            DKADiskInfo.AllDiscInfo();
            DKADiskInfo.DriveSystem(@"D:\");

            // 3 

            DKAFileInfo.GetFileInfo("G:\\Программы малышей\\ЛабораторныеРаботы\\OOP\\laba12\\laba12\\DKALogfile.txt");

            // 4 

            DKADirInfo.GetDirInfo("G:\\Программы малышей\\ЛабораторныеРаботы\\");


            // 5 

            DKAFileManager.GetAllDirsAndFilesOfDisk("G:\\");

            DKAFileManager.GetAllFilesWithExtension(@"G:\Программы малышей\ЛабораторныеРаботы\английский язык", ".docx");

            DKAFileManager.CreateZip(@"G:\Программы малышей\ЛабораторныеРаботы\OOP\laba12\laba12\DKAInspect\DKAFiles");

            // 6 


            DKALog.SearchByDate(DateTime.Now);
        }
    }
}
