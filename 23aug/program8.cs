using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass8day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter a number :");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number :");
                int num2 = Convert.ToInt32(Console.ReadLine());
                try
                {
                    div(num1, num2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                Console.ReadLine();

            }
        }

        private static void div(int num1, int num2)
        {
            int k = 0;
            try
            {
                k = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Entered a Non Zero Number");
                Console.WriteLine(ex.StackTrace + "\n");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Result : {0}", k);
            }
        }
    }
}

