using OOPSLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPSLibrary;
using static day13assesments.Class1;

namespace day13assesments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products p1 = new Products();
            p1.Productsid = 1;
            p1.Productname = "water";
            p1.Qtysold = 20;
            p1.Unitprice = 25.32;
            p1.Unitofmeasurement = 21;
            p1.Reorderlevel = 53;
          //  p1.Qtyinhand = 98;

            Products p2 = new Products();
            p2.Productsid = 1;
            p2.Productname = "sand";
            p2.Qtysold = 13;
            p2.Unitprice = 52.32;
            p2.Unitofmeasurement = 45;
            p2.Reorderlevel = 43;
           // p2.Qtyinhand = 88;
           List<Products> plist = new List<Products>();
            plist.Add(p1);
            plist.Add(p2);

            
            Category cat = new Category();

            cat.Categoryid = 1;
            cat.Categoryname = "solid";
            cat.Categorydescription = "abcd";
           
            Console.WriteLine(cat.Categoryid);
            Console.WriteLine(cat.Categoryname);    
            Console.WriteLine(cat.Categorydescription);
            foreach (var item in cat.Catproducts)
            {
                Console.WriteLine(item.Categoryid);
                Console.WriteLine(item.Categoryname);
                Console.WriteLine(item.Categorydescription);
            }
            Console.ReadLine();
        }
    }
}
