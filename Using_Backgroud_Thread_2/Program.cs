using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Using_Backgroud_Thread_2
{
    class Program
    {
        //Creating a thread with the Thread Class
        public static void ThreadMehod()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("TreadProc {0}", i);
                Thread.Sleep(100);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMehod));
            t.IsBackground = true; // <--- transform into a backgroud thread
            t.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main thread do some work {0}", i);
            }

            //wait until the created thread its finished
           //  t.Join(); 

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main thread MORE @_@ {0}", i);
                Console.ReadKey();
            }
        }
    }
}
