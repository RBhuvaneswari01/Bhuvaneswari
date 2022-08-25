using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reusablecodelibrary
{
    internal class program3
    {
        public static void IndexMethod()
        {
            string str = "pravallika adineni";
            int index1 = str.IndexOf('a');
            Console.WriteLine("The Index Value of character 'a' is " + index1);
            int index2 = str.IndexOf('p');
            Console.WriteLine("The Index Value of character 'p' is " + index2);
        }
    }
}
