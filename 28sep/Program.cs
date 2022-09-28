using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL_Library;

namespace sep28Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            studentoperations s = new studentoperations();
           BLL_Class bal = new BLL_Class();
        //    Console.WriteLine("Add student");
        //    Console.WriteLine("enter studentid");

        //    bal.studid = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("entr studname");
        //    bal.name = Console.ReadLine();

        //    Console.WriteLine("enter courseid");
        //    bal.crsid = Convert.ToInt32(Console.ReadLine());

        //    s.Insertstudent(bal);
        //    Console.WriteLine("record Inserted successfully...");
        //    Console.WriteLine("---------------------------------------------------------------------------");



        //    Console.WriteLine("Update Student");
        //    Console.WriteLine("enter studentid to update");
        //    bal.studid = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("enter student name");
        //    bal.name = Console.ReadLine();
        //    Console.WriteLine("enter courseid");
        //    bal.crsid = Convert.ToInt32(Console.ReadLine());
        //    s.Updatestudent(bal);
        //    Console.WriteLine("Updated successfully....");
        //    Console.WriteLine("----------------------------");




            Console.WriteLine("delete Student");
            Console.WriteLine("enter studentid to delete");
            bal.studid = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter student name");
            //bal.name = Console.ReadLine();
            //Console.WriteLine("enter courseid");
            //bal.crsid = Convert.ToInt32(Console.ReadLine());
            s.Deletestudent(bal);
            Console.WriteLine("deleted successfully....");
            Console.WriteLine("----------------------------");
            Console.ReadLine(); 
        }
    }
}
