using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _16_Using_Parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            Parallel.For(0, 10, (i) =>
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });

            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Parallel.ForEach(myArray, (i) =>
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });
        }
    }
}
