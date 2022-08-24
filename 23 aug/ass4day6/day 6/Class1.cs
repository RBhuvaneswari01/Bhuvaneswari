using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace day_6
{
    internal class Class1
    {

    }
    struct Employee
    {
        int Employeeno;
        string Employeename;
        int Employeesal;
        string Employeedept;







        public Employee(int _employeeno, string _employeename, int _employeesal, string _employeedept)
        {
            Employeeno = _employeeno;
            Employeename = _employeename;
            Employeesal = _employeesal;
            Employeedept = _employeedept;
            Console.WriteLine(Employeeno);
            Console.WriteLine(Employeename);
            Console.WriteLine(Employeesal);
            Console.WriteLine(Employeedept);
        }








        public void AcceptBookData(int employeeno, string employeename, int employeesal, string employeedept)
        {
            Employeeno = employeeno;
            Employeename = employeename;
            Employeesal = employeesal;
            Employeedept = employeedept;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(Employeeno);
            Console.WriteLine(Employeename);
            Console.WriteLine(Employeesal);
            Console.WriteLine(Employeedept);
        }


    }
}




