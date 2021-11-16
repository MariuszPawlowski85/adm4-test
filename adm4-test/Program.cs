using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Nancy.Hosting.Self;

namespace self_hosting_and_quering
{
    class Program
    {
        private const string Url = "http://127.0.0.1:7778";
        static void Main()
        {
            //var url = "http://127.0.0.1:9000";

            //using (var host = new NancyHost(new Uri(url)))
            //{
            //    host.Start();
            //    Console.WriteLine("Nancy Server listening on {0} ", url);
            //    Console.ReadLine();
            //}
            Task.Run(() =>
            {
                using (var host = new NancyHost(new Uri(Url)))
                {
                    host.Start();
                    Console.WriteLine($"Running on {Url}");
                    Console.WriteLine("Press any key to stop server");
                    Console.ReadKey();
                }
            });

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
                //Console.WriteLine("A");
                //Console.WriteLine("B");

            });
            Console.ReadKey();
        }
    }
}
