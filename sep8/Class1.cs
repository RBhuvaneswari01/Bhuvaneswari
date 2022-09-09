using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day17asslibrary
{
    public class Department
    {
        public int deptno { get; set; }
        public string deptname { get; set; }
        public string deptlocation { get; set; }
    }
    public class employee
    {
        public int EmpId { get; set; }
        public int DeptNo { get; set; }
        public string EmpName { get; set; }
        public int Sal { get; set; }
        public string Mgr { get; set; }
    }
    public class login
    {
        public void check()
        {
            Action<string, string> checkcredentials = (u, p) =>
            {
                if (u != "" && u == "bac" && p != "" && p == "abc@123")
                {
                    Console.WriteLine("U are logged in successfully");
                }
                else
                {
                    Console.WriteLine("Pls check userid/pwd");
                }
            };
            checkcredentials("ba11c", "c@123");
            Console.WriteLine("---------------------------");
        }

    }

}
