using System;
using System.Configuration;
using Microsoft.Owin.Hosting;

namespace SteamManager.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var bind = ConfigurationManager.AppSettings["ServiceBind"];
            var port = ConfigurationManager.AppSettings["ServicePort"];
            WebApp.Start<Startup>(new StartOptions(String.Format("http://{0}:{1}", bind, port)));

            Console.ReadLine();
        }
    }
}
