using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10assesment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Queue q = new Queue(4);

           
           q.Display();

            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);


            q.Display();

            q.Enqueue(60);

            q.Display();

            q.Dequeue();
            q.Dequeue();
            Console.Write(" \n after two node deletion");

            q.Display();

            Console.ReadLine();
        }
    }
}
