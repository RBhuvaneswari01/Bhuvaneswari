using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9
{
    
    
        public struct Student
        {
            public int Id;
            public string Name;
            public int Fees;

            public void SetStudent(int id, string name, int fees)
            {
                Id = id;
                Name = name;
                Fees = fees;
            }

            public void PrintStudent()
            {
                Console.WriteLine("Student details:");
                Console.WriteLine("\tID     : " + Id);
                Console.WriteLine("\tName   : " + Name);
                Console.WriteLine("\tFees   : " + Fees);
                Console.WriteLine("\n");
            }
        }
    }

