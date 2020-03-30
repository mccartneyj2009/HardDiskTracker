using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardDiskTracker
{
    class LargestFiles
    {
        public static void FindLargestFiles()
        {
            string startDirectory = @"C:\Users\13303";
            DirectoryInfo dir = new DirectoryInfo(startDirectory);
            IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

            var queryTenLargest =
            (from file in fileList
             let len = file.Length
             orderby len descending
             select file).Take(10);

            Console.WriteLine("The 10 largest files under {0} are:", startDirectory);

            foreach (var v in queryTenLargest)
            {
                Console.WriteLine("{0}: {1} bytes", v.FullName, v.Length);
            }
        }
    }
}
