using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day16asslibrary
{
    public delegate void LengthDelegate();


    public class Stringlength
    {
        public void length()
        {
            string str = "bhuvana";

            Console.WriteLine("String: " + str);
            Console.WriteLine("String Length: " + str.Length);

            Console.ReadKey();
        }
    }
       
        public delegate void GreetDelegate();
        public class Greetings
        {
            public void greet()
            {
                string str = "anitha";

                Console.WriteLine("hello" + " " + str);


                Console.ReadKey();


            }

        }
     
    
    
    
    
    public delegate void MathDelegate(int No1, int No2);
        public class Multicast
        {
           

            public  void Add(int x, int y)
            {
                Console.WriteLine("THE SUM IS : " + (x + y));
            }
            public  void Sub(int x, int y)
            {
                Console.WriteLine("THE SUB IS : " + (x - y));
            }
            public void Mul(int x, int y)
            {
                Console.WriteLine("THE MUL IS : " + (x * y));
            }
        }
       
    
    
    
    
    public delegate void displayProducts(Product p);
        public class Product
        {
            public int Productid { get; set; }
            public string Productname { get; set; }

            public static void Print(Product p)
            {
                Console.WriteLine("Product Id : " + p.Productid);
                Console.WriteLine("Product Name : " + p.Productname);
            }
        }


    public delegate int join(Employee e);
    public class Employee
    {
        public int joiningYear { get; set; }

    }
    public delegate string Concat(string s1, string s2);
}

