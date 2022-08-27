using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9
{
  
    internal class aa4
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("bhuvana");
            list.AddLast("mamatha");
            list.AddAfter(list.First, "hema");
            list.AddBefore(list.Last, "koushik");
            list.AddBefore(list.Last.Previous, "shanvika");
            list.AddAfter(list.First.Next, "minnu");
            list.Find("hema");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();
        }
    }
}
