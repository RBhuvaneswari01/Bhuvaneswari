using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _6th_ass
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            s1.Push(1);
            s1.Push(23);
            s1.Push(43);
            s1.Push(25);
            Console.WriteLine("elements before pop");
            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }

            s1.Pop();
            s1.Pop();
            Console.WriteLine("elements after pop");
            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("element at top is="+s1.Peek());
            Console.WriteLine("element count is=" + s1.Count);
            Console.ReadLine();
        }
    }
}
