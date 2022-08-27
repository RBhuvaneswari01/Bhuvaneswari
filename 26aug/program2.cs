using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace day9_2_
{
    internal class program2
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[2];

            for (int i = 0; i < s.Length; i++)
            {
                s[i] = new Student();
                Console.WriteLine("Enter rollno");
                s[i].RollNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter stdname");
                s[i].StdName = Console.ReadLine();
                Console.WriteLine("Enter Deptno");
                s[i].DeptNo = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("----------------------");

            foreach (var item in s)
            {
                Console.WriteLine("Following are the details");
                Console.WriteLine("rollno :" + item.RollNo);
                Console.WriteLine("student name" + item.StdName);
                Console.WriteLine("department number" + item.DeptNo);

            }
            Console.Read();

        }
    }

    internal class Student
    {
        public int RollNo { get; internal set; }
        public string StdName { get; internal set; }
        public int DeptNo { get; internal set; }
    }
}
