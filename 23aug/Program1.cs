using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_2_day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            add(num1, num2);
            Console.ReadLine();
        }
        static void add(int num1, int num2)
        {
            Console.WriteLine("The sum is {0}", num1 + num2);
        }
    }
    }

