using balLibrary;
using helperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep26adoday2
{
    public class mainmember
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("--------------------------------");
            member_helper helper = new member_helper();
            member_BAL s = new member_BAL();
            Console.WriteLine("Enter member id");
            s.Member_Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter membername");
            s.Member_Name = Console.ReadLine().Trim();
            Console.WriteLine("Enter account open date");
            s.Acc_Open_Date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter max books allowed");
            s.Max_Books_Allowed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Penalty amount");
            s.Penalty_Amount = Convert.ToDouble(Console.ReadLine());



            bool queryStatus = helper.AddMember(s);
            if (queryStatus)
            {
                Console.WriteLine("Book added successfully.....");
            }
            else
            {
                Console.WriteLine("Some error occured...");
            }
            bool Status = helper.EditMember(s);
            if (Status)
            {
                Console.WriteLine("Employee updated successfully.....");
            }
            else
            {
                Console.WriteLine("Some error occured...");
            }

            Console.ReadLine();
        }
    }
}
