using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _3rd_ass
    {
        static void Main(string[] args)
        {
            int i, sum=0, n;
            int[] a = new int[3];

            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} number of elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.Write("Input  sum of elements in the array :{0}\n", sum);







            Console.ReadLine();
        }
    }
}
