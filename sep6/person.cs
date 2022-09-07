using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15asslibrary
{
    abstract class Person
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public string City { get; set; }
        public abstract void work();

    }

    class Employee : Person
    {
        public override void work()
        {
            Console.WriteLine("this is the method of employee class");
        }
    }
    class Manager : Person
    {
        public override void work()
        {
            Console.WriteLine("this is the method of manager class");
        }
    }
    class Clerk : Person
    {
        public override void work()
        {
            Console.WriteLine("this is the method of clerk class");
        }
    }



}
