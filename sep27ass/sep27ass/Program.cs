using Disconnected_BLL;
using Disconnected_helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep27ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Institute Management System");
            Console.WriteLine("--------------------------------");
            helper_class helper = new helper_class();
            Console.WriteLine("Menu");
            Console.WriteLine("-----");
            Console.WriteLine("1. Add New student \n 2. Update student \n 3. Find student \n 4. Show All \n 5.Delete ");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            BLL_class stud = new BLL_class();

            switch (userchoice)
            {
                case 1:

                    Console.WriteLine("Enter studentid");
                    stud.studid = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter studentname");
                    stud.name = Console.ReadLine().Trim();
                    Console.WriteLine("Enter courseid");
                    stud.crsid = Convert.ToInt32(Console.ReadLine());


                    bool queryStatus = helper.AddNewEmployee(stud);
                    if (queryStatus)
                    {
                        Console.WriteLine("student added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 2:
                    Console.WriteLine("enter original student id");
                    int studid = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter new student id");
                    stud.studid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter name");
                    stud.name = Console.ReadLine().Trim();
                    Console.WriteLine("Enter courseid");
                    stud.crsid = Convert.ToInt32(Console.ReadLine());




                    queryStatus = helper.EditstudentData(studid, stud);
                    if (queryStatus)
                    {
                        Console.WriteLine("Student updated successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }

                    break;
                case 3:
                    Console.WriteLine("enter  emp id");
                    stud.studid = Convert.ToInt32(Console.ReadLine());
                    BLL_class data = helper.Locatestudent(stud.studid);
                    if (data != null)
                    {
                        Console.WriteLine("Following are the details");
                        Console.WriteLine(data.studid);
                        Console.WriteLine(data.name);
                        Console.WriteLine(data.crsid);

                    }
                    else
                    {
                        Console.WriteLine("Invalid student id");
                    }
                    break;



                    case 4:
                    List<BLL_class> slist = new List<BLL_class>();
                    slist = helper.studentList();
                    Console.WriteLine("studid" + "        " + "name" + "          " + "crsid");
                    foreach (var item in slist)
                    {
                        Console.WriteLine(item.studid + "       " + item.name + "           " + item.crsid);
                       
                        Console.WriteLine();
                    }


                   break;
                case 5:
                    Console.WriteLine("enter  student id");
                    stud.studid = Convert.ToInt32(Console.ReadLine());
                    queryStatus = helper.RemoveStudentData(stud.studid);
                    if (queryStatus)
                    {
                        Console.WriteLine("student Deleted successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }


                    break;
                default:
                    break;
            }
            Console.ReadKey();


        }
           
        

    }
}

