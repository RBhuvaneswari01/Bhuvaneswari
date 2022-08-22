using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _12th_ass
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 1, 2, 3, 4, 5 ,6,7,8,9,10};
            int i;

           
            int max = arr[0];
            int min = arr[0];
         
            for (i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];

            Console.WriteLine("Largest in given "
                 + "array is " + max);
            for (i = 1; i < arr.Length; i++)
                if (arr[i] > min)
                    max = arr[i];

            Console.WriteLine("Largest in given "
                 + "array is " + min);
            Console.ReadLine();
        }
       
            }
        }
    

