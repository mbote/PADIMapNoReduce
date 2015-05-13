using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Net.Sockets;
using System.IO;
using PADIMapNoReduce;


namespace Worker
{
    
    public static class HelperMethods
    {
        public static IEnumerable<Type> GetLoadableTypes(this Assembly assembly)
        {
            if (assembly == null) throw new ArgumentNullException("assembly");
            try
            {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                foreach (Exception ei in e.LoaderExceptions)
                    Console.WriteLine(ei.Message);
                return e.Types.Where(t => t != null);
            }
        }
    }
    public class WorkerServices:MarshalByRefObject,IWorker
    {
        private bool isJobTracker;
        public IClient client;

        public void setClient(string clientAddress)
        {
            client = (IClient)Activator.GetObject(typeof(IClient), clientAddress);
        }

        public void setJobTracker(bool b)
        {
            isJobTracker = b;
        }

        public bool SendMapper(byte[] code, string className)
        {
            Assembly assembly = Assembly.Load(code);
            // Walk through each type in the assembly looking for our class
            foreach (Type type in HelperMethods.GetLoadableTypes(assembly))
            {
                if (type.IsClass == true)
                {
                    if (type.FullName.EndsWith("." + className))
                    {
                        // create an instance of the object
                        object ClassObj = Activator.CreateInstance(type);

                        // Dynamically Invoke the method
                        object[] args = new object[] { "testValue" };
                        object resultObject = type.InvokeMember("Map",
                          BindingFlags.Default | BindingFlags.InvokeMethod,
                               null,
                               ClassObj,
                               args);
                        IList<KeyValuePair<string, string>> result = (IList<KeyValuePair<string, string>>)resultObject;
                       //TODO: Call client method to send mapping results
                        client.setMappingResult(result);

                        Console.WriteLine("Map call result was: ");
                        foreach (KeyValuePair<string, string> p in result)
                        {
                            Console.WriteLine("key: " + p.Key + ", value: " + p.Value);
                        }
                        return true;
                    }
                }
            }
            throw (new System.Exception("could not invoke method"));
        }
    }
}
