using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BusinessLogicLibrary;
namespace adoday1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string connectionstring = "Data Source=DESKTOP-0NA7TAB\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            //Console.WriteLine("enter the product id to search the books for: ");
            Console.WriteLine("enter the product name to search the books for: ");

            BL_products p = new BL_products();
           // p.productid = Convert.ToInt32(Console.ReadLine());

            p.ProductName = Console.ReadLine();
            SqlConnection cn = new SqlConnection(connectionstring);
          
           // SqlCommand cmd = new SqlCommand("select * from Products where ProductId='" + p.productid + "'", cn);
            SqlCommand cmd1 = new SqlCommand("select * from products where productname='" +p.ProductName + "'", cn);
            cn.Open();
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["productid"]);
                Console.WriteLine(dr["productName"]);
                Console.WriteLine(dr["SupplierId"]);
                Console.WriteLine(dr["CategoryId"]);
                Console.WriteLine(dr["Quantityperunit"]);
                Console.WriteLine(dr["Unitprice"]);
                Console.WriteLine(dr["Unitsinstock"]);
                Console.WriteLine(dr["Unitsonorder"]);
                Console.WriteLine(dr["ReorderLevel"]);
                Console.WriteLine(dr["Discontinued"]);

                Console.WriteLine("---------------------------------");

            }


            Console.ReadLine();
            cn.Close();
        }
    }
}   