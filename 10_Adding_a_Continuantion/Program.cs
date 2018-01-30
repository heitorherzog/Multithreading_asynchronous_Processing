using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Adding_a_Continuantion
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });

            t = t.ContinueWith((i) =>
            {
                return i.Result * 2;
            }).ContinueWith((i) =>
            {
                throw new Exception();
                return 0;

            }).ContinueWith((i) =>
             {
                Console.WriteLine("faulted");
                 return 0;

             }, TaskContinuationOptions.OnlyOnFaulted);

            Console.WriteLine(t.Result);
            Console.ReadKey();
        }
    }
}
