using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _7th_ass
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue();
            q1.Enqueue(1);
            q1.Enqueue(23);
            q1.Enqueue(43);
            q1.Enqueue(25);
            Console.WriteLine("elements in queue");
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

            q1.Dequeue();
            q1.Dequeue();
            Console.WriteLine("elements in queue");
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("element at top is=" + q1.Peek());
            Console.ReadKey();
        }
    }
}
