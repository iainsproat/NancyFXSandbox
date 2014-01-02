using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

using Nancy.Hosting.Self;

namespace TestNancy
{
    public class EntryPoint
    {
        private const string startUrl = "http://localhost:62259";
        [STAThread]
        public static void Main()
        {
            using (var host = new NancyHost(new Uri(startUrl)))
            {
                Console.WriteLine("Launching a self-hosted NancyFX application!");
                host.Start();
                //Process.Start(startUrl);
                Console.ReadLine();
            }
        }
    }
}