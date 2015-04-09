using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Net.Sockets;
using System.IO;
using LibPADIMapNoReduce;

namespace Client
{
   public class Client
    {
        static void Main(string[] args)
        {
            
            string urlWorker = String.Empty;
            string urlClinte = "tcp://localhost:" + args[0] + "C";
            string urlMaster = "tcp://localhost:20001/PM";


            TcpChannel channel = new TcpChannel(Int16.Parse(args[0]));
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(ClientService), "C",
                WellKnownObjectMode.Singleton);
            System.Console.WriteLine("Press <enter> to terminate chat server...");
            System.Console.ReadLine();

                
            IMaster mt = (IMaster)Activator.GetObject(
                typeof(IMaster), urlMaster);

            IWorker wk = (IWorker)Activator.GetObject(
               typeof(IWorker), urlMaster);
        }
    }
}
