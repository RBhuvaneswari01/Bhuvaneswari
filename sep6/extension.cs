using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15asslibrary
{
    public static class Extensions
    {

        public static void withdraw(this Savings p)
        {




            Console.WriteLine("Enter the amt to withdraw from savings account:");
            int amt = Convert.ToInt32(Console.ReadLine());
            bool status = Withdraw(amt);
            if (status)
            {
                Console.WriteLine("Thanks for using atm");
            }
            else
            {
                Console.WriteLine("Some problem occured....");
            }

        }


        static bool Withdraw(int amt)
        {
            int AvailableBalace = 10000;
            bool status = false;
            if (amt <= AvailableBalace)
            {
                AvailableBalace = AvailableBalace - amt;
                status = true;
            }
            Console.WriteLine("After withdraw available bal in savings account=" + AvailableBalace);

            return status;
        }
        public static void Currentwithdraw(this Current p)
        {



            Console.WriteLine("Enter the amt to withdraw from current account:");
            int amt = Convert.ToInt32(Console.ReadLine());
            bool status = CurrentWithdraw(amt);
            if (status)
            {
                Console.WriteLine("Thanks for using atm");
            }
            else
            {
                Console.WriteLine("Some problem occured....");
            }

        }


        static bool CurrentWithdraw(int amt)
        {
            int AvailableBalace = 10000;
            bool status = false;
            if (amt <= AvailableBalace)
            {
                AvailableBalace = AvailableBalace - amt;
                status = true;
            }
            Console.WriteLine("After withdraw available bal in current account=" + AvailableBalace);

            return status;
        }



    }
}
