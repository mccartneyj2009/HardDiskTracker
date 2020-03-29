using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardDiskTracker
{
    class GeneralDiskInformation
    {
        public static void GetAttachedDisks(Array drives)
        {
            foreach (DriveInfo drv in drives)
            {
                string driveLabel = drv.VolumeLabel;
                Console.Write("{0} ",driveLabel);
                string driveName = drv.Name;
                Console.WriteLine(driveName);
                string driveType = Convert.ToString(drv.DriveType);
                Console.WriteLine("Drive Type: {0}", driveType);
            }
        }
    }
}
