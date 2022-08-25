using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reusablecodelibrary
{
    internal class program4
    {
        public static void Split()
        {
            string newStr = "Welcome to the world of C# Programming";
            string[] sep = { "#", };

            int a = 2;
            string[] result = newStr.Split(sep, a, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
