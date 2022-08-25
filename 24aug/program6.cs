using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reusablecodelibrary
{
    internal class program6
    {
        public static void creatingfile()
        {
            string path = @"D\c#\basic codes\ConsoleApp1\day 7firstfile.txt";
            File.Create(path);
        }

    }
}
