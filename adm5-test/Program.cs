using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ocalhost_quering
{
    class Program
    {
        private const string Url = "http://127.0.0.1:7778";
        static void Main()
        {
            _ = Task.Run(() =>
            {
                while (true)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = client.SendAsync(
                            new HttpRequestMessage(
                                HttpMethod.Get,
                                new Uri("http://127.0.0.1:7778")
                            )
                        ).Result;
                        //Console.WriteLine("A");
                        Console.WriteLine(response.StatusCode);
                        Thread.Sleep(1000);
                    }
                }

            });
            Console.ReadKey();
        }
    }
}
