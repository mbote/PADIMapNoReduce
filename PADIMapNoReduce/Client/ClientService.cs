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
   public class ClientService:MarshalByRefObject,IClient
    {
       public static ClientForm form;
       private IList<KeyValuePair<string, string>> mapResults;

       public ClientService() { }

       public bool SendMapper(byte[] b, string s) {
           return true;
       }

       public string getFileSplit(int fstLine, int lstLine)
       {
           return "DummyLine";
       }

       public void setMappingResult(IList<KeyValuePair<string, string>> mapResults)
       {
           this.mapResults = mapResults;
       }
    }
}
