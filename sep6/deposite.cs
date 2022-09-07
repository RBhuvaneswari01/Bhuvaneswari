using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15asslibrary
{
    public static class Deposit
    {

        public static void deposit(this Savings p)
        {
            int AvailableBalace = 10000;
            Console.WriteLine("Enter the amt to deposit to savings account");
            int amt = Convert.ToInt32(Console.ReadLine());
            if (amt > 0)
            {
                AvailableBalace = AvailableBalace + amt;

            }
            else
            {
                Console.WriteLine("cant add to the account");
            }
            Console.WriteLine("After Deposit available bal in savings account=" + AvailableBalace);


        }

        public static void currentdeposit(this Current p)
        {
            int AvailableBalace = 10000;
            Console.WriteLine("Enter the amt to deposit from current account");
            int amt = Convert.ToInt32(Console.ReadLine());
            if (amt > 0)
            {
                AvailableBalace = AvailableBalace + amt;

            }
            else
            {
                Console.WriteLine("cant add to the account");
            }
            Console.WriteLine("After Deposit available bal in current account=" + AvailableBalace);


        }
    }
}
