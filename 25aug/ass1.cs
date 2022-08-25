using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;

namespace filehandling
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string path = @"D:\git assignments\";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();


            fname = string.Concat(path, fname);


            Console.WriteLine("file created successfully...");
            Console.WriteLine("Enter your file contents");
            string con = Console.ReadLine();
            string[] contents = new string[2];
            contents[0] = con;
            File.WriteAllLines(fname, contents);


            Console.WriteLine("file created successfully with contents...");
            File.Copy(fname, "copiedFile.txt");
            File.Move(fname, "MovedFile.txt");
            File.Delete( @"D:\git assignments\extrafiles.txt");
            FileInfo fileInfo = new FileInfo(fname);
            Console.WriteLine(fileInfo.FullName + "  Full Name");
            Console.WriteLine(fileInfo.DirectoryName + " DirectoryName");
            Console.WriteLine(fileInfo.CreationTime);
            Console.ReadLine();


        }

        }
    }
   


       

    

    


        
    
