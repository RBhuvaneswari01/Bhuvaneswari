using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15asslibrary
{
    public class Savings : IBank
    {
        int year;
        double princamt, rate, interest, total_amt;
        public void CalculateInterest()
        {

            Console.Write("Enter The Loan Amount of savings account: ");
            princamt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Number of Years : ");
            year = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the Rate Of Interest of savings account : ");
            rate = Convert.ToDouble(Console.ReadLine());
            interest = princamt * year * rate / 100;


        }
        public void PrintBalance()
        {
            total_amt = princamt + interest;
            Console.WriteLine("Total Amount in savings : {0}", total_amt);
            Console.ReadLine();

        }

    }
}
