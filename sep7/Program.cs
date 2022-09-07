using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day16asslibrary;
using static day16asslibrary.Stringlength;

namespace day16ass
{
      public class Program
     {
        static void Main(string[] args)
        {
            Stringlength str=new Stringlength();
            LengthDelegate len = new LengthDelegate(str.length);
            len.Invoke();
            

            Console.WriteLine("---------------------------------------------------------------");

            Greetings g = new Greetings();
            GreetDelegate s = new  GreetDelegate(g.greet);
            s();

            Console.WriteLine("---------------------------------------------------------------");


            Multicast m = new Multicast();
            MathDelegate del1 = new MathDelegate(m.Add);
            MathDelegate del2 = new MathDelegate(m.Sub);
            MathDelegate del3 = new MathDelegate(m.Mul);
            del1(5,6);
            del2(5,6);
            del3(5, 6);
           
            
            Console.WriteLine("---------------------------------------------------------------");


            Product p1 = new Product() { Productid = 1, Productname = "bench" };
            Product p2 = new Product() { Productid = 2, Productname = "Chair" };
            Product p3 = new Product() { Productid = 3, Productname = "board" };
            Product p4 = new Product() { Productid = 4, Productname = "marker" };
            displayProducts p = new displayProducts(Product.Print);
            p(p1);
            p(p2);
            p(p3);
            p(p4);
           
            Console.WriteLine("---------------------------------------------------------------");

            Employee e1 = new Employee() { joiningYear = 2000 };
            Employee e2 = new Employee() { joiningYear = 2010 };

            Employee e3 = new Employee() { joiningYear = 2008 };


            join j = delegate (Employee e) { return DateTime.Now.Year - e.joiningYear; };
            int emp1 = j(e1);
            Console.WriteLine("years of service : " + emp1);
            int emp2 = j(e2);
            Console.WriteLine("years of service : " + emp2);
            int emp3 = j(e3);
            Console.WriteLine("years of service : " + emp3);

            Console.WriteLine("------------------------------------------------------------------");

            Concat y = delegate (string s1, string s2) { return s1 + s2; };
            Console.WriteLine(y("hi this is","bhuvana"));

            Console.ReadLine();
        }
    }
   
       
}
