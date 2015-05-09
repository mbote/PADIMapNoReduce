using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Net.Sockets;
using System.IO;
using LibPADIMapNoReduce;


namespace PuppetMaster
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPuppetMaster());
        }

        public static void Connection(string port)
        {          
            TcpChannel channel = new TcpChannel(Int16.Parse(port));
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(PuppetMasterServices), "PM",
                WellKnownObjectMode.Singleton);
            System.Console.WriteLine("Press <enter> to terminate Puppet Master...");
            System.Console.ReadLine();
        }

    }
}
