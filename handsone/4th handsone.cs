using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class _4th_handsone
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            if(a==0)
            {
                Console.WriteLine("the entered number is zero");
            }
            else
                Console.WriteLine("the entered number is not zero");
            if(a%2==0)
                Console.WriteLine("the entered number is even");
            else
                Console.WriteLine("the entered number is odd");
            if (a % 10 == 0)
                Console.WriteLine("the entered number is multiple of 10");
            else
                Console.WriteLine("the entered number is not a multiple of 10");
            if (a > 100)
                Console.WriteLine("the entered number is too large");

            Console.ReadLine();
        }
    }
}
