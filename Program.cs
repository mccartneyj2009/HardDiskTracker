﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardDiskTracker
{
    class DriveInformation
    {
        static void Main(string[] args)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo drv in allDrives)
            {
               const double gbConversion = 1073741824;
                double gbDiskAvail = drv.AvailableFreeSpace;
                double gbDiskStart = drv.TotalSize;
                string type = Convert.ToString(drv.DriveType);
                string name = drv.Name;
                string label = drv.VolumeLabel;
                int diskAvail = Convert.ToInt32(gbDiskAvail / gbConversion);
                int diskStart = Convert.ToInt32(gbDiskStart / gbConversion);

                Console.WriteLine("Name of Disk: " + name);
                Console.WriteLine("Disk Label: " + label);
                Console.WriteLine();
                Console.WriteLine(diskAvail + "gb free.");
                Console.WriteLine(diskStart + " gb total disk size.");
                Console.WriteLine();
                Console.WriteLine(drv.TotalFreeSpace + " Bytes free.");
                Console.Write(drv.TotalSize + " Bytes total disk size.");

                Console.ReadKey();
            }
        }
    }
}
