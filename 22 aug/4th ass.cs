using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class _4th_ass
    {
        static void Main(string[] args)
        {

            ArrayList array = new ArrayList(5);
            array.Add(2);
            array.Add(3);
            array.Add(5);
            array.Add(8);
            array.Add(10);
            Console.WriteLine("The initial ArrayList: ");

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }


            array.RemoveRange(0, 4);


            Console.WriteLine("The ArrayList after Removing elements: ");


            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            int result = array.Count;
            Console.WriteLine(result);
            Console.ReadLine();


        }
        

    }
}
       
    

