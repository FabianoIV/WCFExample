using System;
using System.ServiceModel;
using Wcf.ServiceContract;

namespace Wcf.Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var uris = new Uri[1];
            string address = "net.tcp://localhost:6565/MessageService";
            uris[0] = new Uri(address);
            IMessageService message = new MessageService();
            ServiceHost host = new ServiceHost(message, uris);

            var binding = new NetTcpBinding(SecurityMode.None);
            host.AddServiceEndpoint(typeof(IMessageService), binding, address);
            host.Opened += Host_Opened;
            host.Open();

            Console.ReadLine();
        }
        
        private static void Host_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Host Opened");
        }
    }
}
