using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reusablecodelibrary
{
    internal class program7
    {
        public static void Datetiime()
        {

            DateTime dt = new DateTime();
            dt = DateTime.Now;
            Console.WriteLine("Day=  " + dt.Day);
            Console.WriteLine("Month=  " + dt.Month);
            Console.WriteLine("Year=" + dt.Year);
            Console.WriteLine("Hour = " + dt.Hour);
            Console.WriteLine("minute = " + dt.Minute);
            Console.WriteLine("sec = " + dt.Second);
            Console.WriteLine("millisecond=" + dt.Millisecond);
            Console.WriteLine("Day of year " + dt.DayOfYear);

        }
    }
}
