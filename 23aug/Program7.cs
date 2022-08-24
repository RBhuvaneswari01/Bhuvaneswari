using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass7day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            Console.WriteLine("enter i");
            i=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter j");
            j = Convert.ToInt32(Console.ReadLine());
            try
            {
                int k;
                k = i / j;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("StackTrace:'{0}' ", Environment.StackTrace);
            }Console.Read();
        }
    }
}
