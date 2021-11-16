using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.Hosting.Self;

namespace hosting_on_IP
{
    class Program
    {
        private const string Url = "http://10.150.16.62:7778"; //change IP for your server
        static void Main()
        {
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
            Console.ReadKey();
        }
    }
}
