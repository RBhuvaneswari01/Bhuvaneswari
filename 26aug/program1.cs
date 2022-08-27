using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace day9
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Student[] S = { new Student(), new Student() };

            S[0].SetStudent(101, "bhuvana", 7000);
            S[1].SetStudent(102, "navya", 10000);

            S[0].PrintStudent();
            S[1].PrintStudent();
            Console.ReadLine();
        }
    }
}
