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



namespace Worker
{
    public class Worker
    {
        [STAThread]
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(30001);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(WorkerServices), "W",
                WellKnownObjectMode.Singleton);
            System.Console.WriteLine("Press <enter> to terminate worker...");
            System.Console.ReadLine();
           /* IMaster mt = (IMaster)Activator.GetObject( typeof(IWorker),
                                                       "tcp://localhost:20001/PM");*/
        }
    }
}
