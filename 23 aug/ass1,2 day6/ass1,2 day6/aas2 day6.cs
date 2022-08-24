using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_2_day6
{
    internal class aas2_day6
    {
        static void Main(string[] args)
        {

        
        Console.WriteLine("Enter first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The sum is {0}", add(num1, num2));
            Console.ReadLine();
        }
    static int add(int num1, int num2)
    {
        return num1 + num2;
    }
}
}
