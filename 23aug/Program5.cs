using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass5day6
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

    }
    struct Employee
    {
        public int empNo;
        public string ename;
        public double sal;
        public int deptNo;
        public void AcceptData(int empNo, string ename, double sal, int deptNo)
        {
            this.empNo = empNo;
            this.ename = ename;
            this.sal = sal;
            this.deptNo = deptNo;
        }
        public void Display1()
        {
            Console.WriteLine("EmployeeNo : {0} EmployeeName: {1} EmployeeSal: {2} EmployeeDeptNo : {3}   ", this.empNo, this.ename, this.sal, this.deptNo);
            //Console.Write("EmployeeName : {0}   ",this.ename);
            //Console.Write("EmployeeSal : {0}   ",this.sal);
            //Console.Write("EmployeeDeptNo : {0}  ",this.deptNo);
            Console.ReadLine();
        }
    }
}

