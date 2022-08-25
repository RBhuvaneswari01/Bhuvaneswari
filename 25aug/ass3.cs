using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filehandling
{
    internal class ass3
    {
        static void Main(string[] args)
        {
            string root = @"D:\git assignments\results";

            // If directory does not exist, create it.  
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            else
            {
                Console.WriteLine("already exists");
            }
            string subdr1 = @"D:\git assignments\Results\Results 17-18";
            if (!Directory.Exists(subdr1))
            {
                Directory.CreateDirectory(subdr1);
            }
            string subdr2 = @"D:\git assignments\Results\Results 18-19";
            if (!Directory.Exists(subdr2))
            {
                Directory.CreateDirectory(subdr2);
            }
            string subdr3 = @"D:\git assignments\Results\Results 20-21";
            if (!Directory.Exists(subdr3))
            {
                Directory.CreateDirectory(subdr3);
            }
            string[] drs = Directory.GetDirectories(root);
            foreach (var item in drs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
