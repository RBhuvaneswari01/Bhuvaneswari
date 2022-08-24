using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass6_day6
{
    internal class Program
    {
        enum Deptnames
        {
            Purchases,
            Sales,
            Training,
            Accounts,
        }

        static void Main(string[] args)
        {
            int myNum = (int)Deptnames.Sales;
            Console.WriteLine(myNum);
            Console.ReadLine();
        }
    }
        
}
