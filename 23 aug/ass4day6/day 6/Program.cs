using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Employee bk1=new Employee();


            Console.WriteLine("Enter Employeeno");
            int e_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employeename");
            string e_name= (Console.ReadLine());

           Console.WriteLine("Enter Employeesal");
            int  e_sal= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employeedept");
            string e_dept = (Console.ReadLine());

            bk1.AcceptBookData(e_no, e_name, e_sal, e_dept);
            Console.WriteLine("Now Printing the data");
            bk1.DisplayInfo();


            Console.ReadLine();
        }
    }
}
