using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Using_parameterizedThreadStart_3
{
    class Program
    {
        //Creating a thread with the Thread Class
        public static void ThreadMehod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("TreadProc {0}", i);
                Thread.Sleep(100);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMehod));
            t.Start(15);
            t.Join();

        }
    }
}
