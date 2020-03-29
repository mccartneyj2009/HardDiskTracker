using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardDiskTracker
{
    class DriveAvailableSpace
    {
        public static void DiskAvailable(Array drives)
        {
            foreach (DriveInfo drv in drives)
            {
                const double gbConversion = 1073741824;
                double gbDiskAvail = drv.TotalSize;
                int diskAvail = Convert.ToInt32(gbDiskAvail / gbConversion);

                Console.WriteLine("Total Disk Size: {0} gB", diskAvail);
            }
        }
    }
}
