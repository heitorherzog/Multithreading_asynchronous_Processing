﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Starting_new_task
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 100; i++)
            {   
                Console.Write("*");
            }
        }

        static void Main(string[] args)
        {

            Task t = Task.Run(action:ThreadMethod);

            t.Wait();

        }
    }
}
