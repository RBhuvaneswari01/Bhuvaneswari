using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace day14ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCategory bcat = new BookCategory();
            Console.WriteLine("Book Category id : {0}, Book Category Name : {1}, BookCategory Description : {2}", bcat.CategoryID, bcat.CategoryName,bcat.Description);

            BookCategory bcat2 = new BookCategory(1, "Pride and prejudice" ,"Classics type");
            Console.WriteLine("Book Category id : {0}, Book Category Name : {1}, BookCategory Description : {2}", bcat2.CategoryID, bcat2.CategoryName, bcat2.Description);

            Book b = new Book();
            Console.WriteLine("Book  id : {0}, Book Name : {1}, Book Description : {2}", b.BookID, b.BookName, b.Price);

            Book b2 = new Book(2, "Strange Planet", 500);
            Console.WriteLine("Book  id : {0}, Book Name : {1}, Book Description : {2}", b2.BookID, b2.BookName, b2.Price);

            Cart c1 = new Cart();
            c1.AddToCart(b1);
            c1.AddToCart(b2);
            c1.AddToCart(b3);
            c1.AddToCart(b4);
            c1.Display();

        }
    }
}
