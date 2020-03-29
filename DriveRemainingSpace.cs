using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardDiskTracker
{
    class DriveRemainingSpace
    {
        public static void DiskRemaining(Array drives)
        {
            foreach (DriveInfo drv in drives)
            {
                const double gbConversion = 1073741824;
                double gbDiskFree = drv.AvailableFreeSpace;
                int diskFree = Convert.ToInt32(gbDiskFree / gbConversion);

                Console.WriteLine("Available Disk Space Remaining: {0} gB", diskFree);
            }
        }
    }
}
