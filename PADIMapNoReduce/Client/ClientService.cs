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
    [Serializable]
   public class ClientService:MarshalByRefObject,IClient
    {
       public static ClientForm form;
       private string filePath;
       private string outputFolder;

       public ClientService() { }

       public void setFilePath(string path)
       {
           filePath = path;
       }

       public void setOutputFolder(string path)
       {
           outputFolder = path;
       }

       public bool SendMapper(byte[] b, string s) {
           return true;
       }

       public List<string> getFileSplit(int fstLine, int lstLine)
       {
           List<string> split = new List<string>(); 
           FileStream file = File.OpenRead(filePath);

           for (int i = 1; i <= lstLine - fstLine + 1; i++)
           {
               split.Add(File.ReadLines(filePath).Skip(fstLine - 2 + i).Take(1).First());
               Console.WriteLine("Wrote line nr. " + (fstLine + i - 1));
           }

           return split;
       }


        //TODO: Not sure if there should be a splitNr here.
       public void setMappingResult(IList<KeyValuePair<string, string>> mapResults, int splitNr)
       {
           using (StreamWriter writer = new StreamWriter((outputFolder + "/" + splitNr + ".out"), true)) {
               foreach (KeyValuePair<string, string> pair in mapResults) {
                   writer.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
               }
           }
       }
    }
}
