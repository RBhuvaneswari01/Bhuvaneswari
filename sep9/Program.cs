using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace day18demo
{
    class Threading
    {
        static void M1()
        {
            Console.WriteLine("The current thread which is running = " + Thread.CurrentThread.Name);
            for (int i = 0; i <=10; i++)
            {
              Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(M1);
            Thread t2 = new Thread(new ThreadStart(M1));
            t1.Name = "mythread";
            t1.Start();
            t2.Name = "mythread2";
            t2.Start();
            t2.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.Lowest;
            
            using (Mutex mutex = new Mutex(false, "MutexDemo"))
            {

                if (!mutex.WaitOne(5000, false))
                {
                    Console.WriteLine("An Instance of the Application is Already Running");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("Application Is Running.......");
                }
                Console.ReadKey();
            }
        }
    }
}
