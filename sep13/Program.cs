using Movies.cs;
using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace day21ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            m1.AddMovieDetails("premam", "Telugu", "romance", 50);
            Movie m2 = new Movie();
            m2.AddMovieDetails("andhukante premanta", "Telugu", "Romance", 60);
            Movie m3 = new Movie();
            m3.AddMovieDetails("spiderman", "English", "action", 100);
            Movie m4 = new Movie();
            m4.AddMovieDetails("ove mocktail", "kanada", "Romance", 60);
            Movie m5 = new Movie();
            m5.AddMovieDetails("krk", "Tamil", "Comedy", 110);
            Movie m6 = new Movie();
            m6.AddMovieDetails("super man", "English", "Thriller", 100);
            Movie m7 = new Movie();
            m7.AddMovieDetails("vikram", "telugu", "Action", 50);
            Movie m8 = new Movie();
            m8.AddMovieDetails("24", "Tamil", "Sci-fi", 120);
            Movie m9 = new Movie();
            m9.AddMovieDetails("arya", "telugu", "romance", 120);
            Movie m10 = new Movie();
            
            
            User u1 = new User();
            User u2 = new User();
            User u3 = new User();
            User u4 = new User();
            User u5 = new User();
            User u6 = new User();

            u1.AddUser("bhuvana", "reddy", "gold");
            u2.AddUser("mamatha", "ramasani", "Silver");
            u3.AddUser("vamsi", "reddy", "platinum");
            u4.AddUser("harika", "honey", "Silver");
            u5.AddUser("jai", "deep", "gold");
            u6.AddUser("sandeep", "reddy", "platinum");
           
            u1.BorrowMovie(m1);
            u2.BorrowMovie(m1);
            u4.BorrowMovie(m1);
            Console.WriteLine("Movie 1 Availability " + m1.Availability);
            u2.RetrunMovie(m1, 4);
            Console.WriteLine("Movie 1 Availability " + m1.Availability);
            u3.BorrowMovie(m1);
            u6.BorrowMovie(m1);
            u5.BorrowMovie(m1);
         
            u1.BorrowMovie(m2);
            u1.RetrunMovie(m2, 5);
            u1.BorrowMovie(m3);
            Console.WriteLine("=================================================");
            u1.ShowMyList();
            Console.WriteLine("=================================================");
            u2.ShowMyList();
            Console.WriteLine("==================================================");
            u1.SearchByLanguage("Telugu");
            Console.WriteLine("==================================================");
            u1.SearchByGenre("Thriller");
            //Console.WriteLine("---------------------------------------xml-----------------------------------");
            //FileStream fs_xml = new FileStream(@"empxmldata.xml", FileMode.Create, FileAccess.Write);
            //XmlSerializer xml = new XmlSerializer(typeof(User));
            //xml.Serialize(fs_xml, u1);
            //fs_xml.Flush();
            //fs_xml.Close();
            //fs_xml.Dispose();



            //Console.WriteLine("---------------------------------------binary-----------------------------------");
            //FileStream f4 = new FileStream(@"moviedata.bin", FileMode.Create, FileAccess.Write);
            //BinaryFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(f4, u1);

            //f4.Flush();
            //f4.Close();
            //f4.Dispose();
            //Console.WriteLine("-----------------------------------soap------------------------------------------");

            //FileStream fs2 = new FileStream("moviedataSoap.soap", FileMode.Create, FileAccess.Write);

            //SoapFormatter soap = new SoapFormatter();
            //soap.Serialize(fs2, u1);
            //fs2.Flush();
            //fs2.Close();
            //fs2.Dispose();

            Console.ReadLine();

        }
    }
}
