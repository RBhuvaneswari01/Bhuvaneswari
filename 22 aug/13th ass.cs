using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _13th_ass
    {
        static void Main(string[] args)
        {
         
            int[] arr = new int[8] { 1,3,5,200,22,2244,213,111};


         int max = 100;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
