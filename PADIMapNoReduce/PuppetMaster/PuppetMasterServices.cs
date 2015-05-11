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


namespace PuppetMaster
{
  public  class PuppetMasterServices:MarshalByRefObject,IMaster
    {
      public bool SendMapper(byte[] b, string s)
      {
          return true;
      }
    }
}
