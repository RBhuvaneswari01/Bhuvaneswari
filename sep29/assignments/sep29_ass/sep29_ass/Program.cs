using DAL_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep29_ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            context.BorrowerTable.Add(new Borrower { borrowerid = 1, borr_name = "Sweety", city="atp", state="andhra", country="india" });
            context.LoanTable.Add(new Loan { LoanID = 1, loantype = "vehical", amount = 20000, duration=50, rateofintrest=2 });
            

            context.SaveChanges();
            Console.WriteLine("done");
            Console.Read();
        }
    }
}
