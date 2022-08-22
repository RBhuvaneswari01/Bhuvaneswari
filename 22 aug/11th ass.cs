using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _11th_ass
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "bhuvana");
            dic.Add(2, "reddy");
            dic.Add(3, "ramasani");
            dic.Add(4, "mamatha");

            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
            Console.WriteLine("Sorted by value");

            foreach (KeyValuePair<Int32, string> item in dic.OrderBy(key => key.Value))
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            
            Console.ReadLine();
        }
    }
}
