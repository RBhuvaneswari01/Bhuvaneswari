using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filehandling
{
    internal class ass4
    {
        static void Main(string[] args)
        {
            var drv = DriveInfo.GetDrives();
            foreach (DriveInfo dInfo in drv)
            {
                Console.WriteLine(dInfo.Name);
            }Console.ReadLine();
        }
    }
}
