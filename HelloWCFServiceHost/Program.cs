using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HelloWCFServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(HelloWCFService.HelloService)))
            {
                serviceHost.Open();
                Console.WriteLine("Service Host Started at " + DateTime.Now.ToString());
                Console.ReadLine();         // this is to just prevent automatic close of the console application. 
            }

        }
    }
}
