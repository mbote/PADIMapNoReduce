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
using PADIMapNoReduce;

namespace Client
{
   public class Client
    {
       IWorker worker;
       IMaster master;
       ClientService clientService;


       public void init(string EntryURL)
       {
           string urlWorker = EntryURL;
           string urlMaster = "tcp://localhost:20001/PM";

           TcpChannel channel = new TcpChannel(10001);
           ChannelServices.RegisterChannel(channel, false);

           clientService = new ClientService();
           RemotingServices.Marshal(clientService, "C", typeof(ClientService));

           master = (IMaster)Activator.GetObject(
               typeof(IMaster), urlMaster);

           worker = (IWorker)Activator.GetObject(
              typeof(IWorker), urlWorker);

           worker.setJobTracker(true);

           System.Console.WriteLine("The worker URL is " + urlWorker);
           System.Console.WriteLine("The master URL is " + urlMaster);
       }

       public void submit(string inputFile, int splitNr, string outputPath, string className, string mappingClass)
       {
		   try
           {
               clientService.setFilePath(inputFile);
               clientService.setOutputFolder(outputPath);

               clientService.getFileSplit(3, 7);
               
               byte[] code = File.ReadAllBytes(mappingClass);
               worker.setClient("tcp://localhost:10001/C");
               Console.WriteLine(worker.SendMapper(code, className));
           }
           catch (SocketException)
           {
               System.Console.WriteLine("Could not locate server");
           }
       }

      /*  static void Main(string[] args)
        {
            
            string urlWorker = String.Empty;
            string urlClinte = "tcp://localhost:" + args[0] + "/C";
            string urlMaster = "tcp://localhost:20001/PM";


            TcpChannel channel = new TcpChannel(Int16.Parse(args[0]));
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(ClientService), "C",
                WellKnownObjectMode.Singleton);
            System.Console.WriteLine("Press <enter> to terminate client...");
            System.Console.ReadLine();

                
            IMaster mt = (IMaster)Activator.GetObject(
                typeof(IMaster), urlMaster);

            IWorker wk = (IWorker)Activator.GetObject(
               typeof(IWorker), urlMaster);
        }*/
    }
}
