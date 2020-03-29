using System;
using System.IO;

namespace HardDiskTracker
{
    class DriveInformation
    {
        static void Main(string[] args)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            GeneralDiskInformation.GetAttachedDisks(allDrives);
            DriveAvailableSpace.DiskAvailable(allDrives);
            DriveRemainingSpace.DiskRemaining(allDrives);
            Console.ReadLine();
        }
    }
}
