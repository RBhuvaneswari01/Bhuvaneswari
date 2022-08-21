using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class _5th_handsone
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter the number");
            i = Convert.ToInt32(Console.ReadLine());
           

            switch (i)
            {


                case int n when (i == 0):
                    Console.WriteLine("Given number is zero");
                    break;
                case int n when (i % 2 == 0):
                    Console.WriteLine("Given number is even");

                    break;
                case int n when (i % 10 == 0):
                    Console.WriteLine("Given number is multiple of 10");

                    break;
                case int n when (i > 100):
                    Console.WriteLine("Given number is multiple of 10");

                    break;
            }
            Console.ReadLine();
            //switch (a % 2)
            //{

            //    case 0:
            //        Console.WriteLine("enterd number  is even number");
            //        break;


            //    case 1:
            //        Console.WriteLine("enterd numbere  is odd number");
            //        break;
            //}
            //        switch (a == 0)
            //        {

            //         case :
            //                Console.WriteLine("enterd number  is  zero");
            //                break;


            //            case :
            //                Console.WriteLine("enterd numbere  is not zero");
            //                break;
            //        }
            //        Console.ReadLine();
        }
        }
    }
