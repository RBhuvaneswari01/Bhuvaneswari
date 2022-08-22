using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _15th_ass
    {
        static void Main(string[] args)
        {
            int count(int[] S, int m, int n)
            {

                if (n == 0)
                    return 1;


                if (n < 0)
                    return 0;


                if (m <= 0)
                    return 0;


                return count(S, m - 1, n) +
                    count(S, m, n - S[m - 1]);
            }



            {

                int[] s = { 1, 2, 3 };
                int m = s.Length;
                Console.Write(count(s, m, 4));

            }
            Console.ReadLine();
        }
    }
    }

