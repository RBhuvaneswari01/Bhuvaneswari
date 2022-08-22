using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _8th_ass
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "ramasani");
            h.Add(2, "bhuvana");
            h.Add(3, "reddy");
           
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + "  " + item.Value);

            }
            Console.WriteLine("tabe after removing a element");
            h.Remove(2);
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + "  " + item.Value);

            }
            Console.ReadLine();

        }
    }
}
