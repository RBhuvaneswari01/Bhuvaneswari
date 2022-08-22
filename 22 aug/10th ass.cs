using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _10th_ass
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "reddy");
            dic.Add(2, "bhuvana");
            dic.Add(3, "ramasani");
            
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);
                
            }
            Console.ReadLine();
        }
    }
}
