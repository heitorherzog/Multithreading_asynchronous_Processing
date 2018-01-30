using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace async_await
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = DownloadContent().Result;
            Console.Write(result);
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string r = await client.GetStringAsync("http://www.microsoft.com");
                return r;
            }
        }
    }
}
