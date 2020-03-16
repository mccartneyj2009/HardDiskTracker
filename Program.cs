using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardDiskTracker
{
    class DriveInformation
    {
        static void Main()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo drv in allDrives)
            {
                double gbConversion = 1073741824;
                double gbDiskAvail = drv.AvailableFreeSpace;
                string type = Convert.ToString(drv.DriveType);
                string name = drv.Name;
                string label = drv.VolumeLabel;

                int diskAvail = Convert.ToInt32(gbDiskAvail / gbConversion);

                
                Console.WriteLine();
                Console.WriteLine(diskAvail);
                Console.WriteLine(drv.TotalFreeSpace + " Bytes");
                Console.Write(drv.TotalSize + " Bytes");
                Console.ReadKey();
            }
        }
    }
}
