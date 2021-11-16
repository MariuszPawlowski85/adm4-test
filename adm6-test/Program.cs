using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ip_quering
{
    class Program
    {
       
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
                                new Uri("http://10.150.16.62:7778") //change ip for your needs
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
