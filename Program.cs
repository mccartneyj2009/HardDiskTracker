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

                Console.WriteLine(diskAvail + " gb");
                Console.WriteLine(diskStart + " gb");
                Console.WriteLine(drv.TotalFreeSpace + " Bytes");
                Console.Write(drv.TotalSize + " Bytes");

                Console.ReadKey();
            }
        }
    }
}
