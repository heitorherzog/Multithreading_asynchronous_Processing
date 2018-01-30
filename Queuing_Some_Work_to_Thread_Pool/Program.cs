using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Queuing_Some_Work_to_Thread_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from the treadpool");
            });

            Console.ReadKey();
        }
    }
}
