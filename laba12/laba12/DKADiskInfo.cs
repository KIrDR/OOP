using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    public class DKADiskInfo
    {
        public static void DriveFreeMemory(string drivePath)
        {
            var allDrives = DriveInfo.GetDrives();

            foreach (var drive in allDrives)
            {
                if(drive.Name == drivePath)
                {

                    Console.WriteLine("Total size: {0}", drive.TotalSize);
                    Console.WriteLine("Free size: {0}", drive.TotalFreeSpace);
                }
            }


            DKALog.WriteToLog("DKADiskInfo.DriveFreeMemory()");
        }
        public static void DriveSystem(string drivePath)
        {
            var allDrives = DriveInfo.GetDrives();

            foreach (var d in allDrives)
            {
                if (d.Name == drivePath)
                {
                    Console.WriteLine("File system: {0}", d.DriveFormat);
                }
            }

            DKALog.WriteToLog("DKADiskInfo.DriveSystem()");

        }
        public static void AllDiscInfo()
        {
            var allDrives = DriveInfo.GetDrives();


            foreach (var d in allDrives)
            {

                Console.WriteLine("Drive name: {0}", d.Name);
                Console.WriteLine("Total size: {0}", d.TotalSize);
                Console.WriteLine("Free size: {0}", d.TotalFreeSpace);
                Console.WriteLine("Root: {0}", d.RootDirectory);
                Console.WriteLine();
            }

            DKALog.WriteToLog("DKADiskInfo.AllDiscInfo()");

        }






    }
}
