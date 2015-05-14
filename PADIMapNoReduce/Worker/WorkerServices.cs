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
        private object mapperClass;
        private Type mapperClassType;
        private int totalSplits;
        private int totalLines;
        public IClient client;

        public void setTotalSplits(int totalSplits)
        {
            this.totalSplits = totalSplits;
        }

        public void setTotalLines(int totalLines)
        {
            this.totalLines = totalLines;
        }

        public void setClient(string clientAddress)
        {
            client = (IClient)Activator.GetObject(typeof(IClient), clientAddress);
        }

        public void setJobTracker(bool b)
        {
            isJobTracker = b;
        }

        private List<KeyValuePair<string, string>> mapSplit(List<string> argsList, object ClassObj, Type type)
        {
            List<KeyValuePair<string, string>> mapResult = new List<KeyValuePair<string, string>>();

            foreach (string s in argsList)
            {
                object[] o = { s };
                IList<KeyValuePair<string, string>> it = (IList<KeyValuePair<string, string>>) type.InvokeMember("Map",
                                                                                            BindingFlags.Default | BindingFlags.InvokeMethod,
                                                                                            null,
                                                                                            ClassObj,
                                                                                            o);
                mapResult.AddRange(it);
            }
            return mapResult;
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
                        mapperClass = Activator.CreateInstance(type);
                        mapperClassType = type;

                        // Dynamically Invoke the method
                        assignTask(1, 10);
                        return true;
                    }
                }
            }
            throw (new System.Exception("could not invoke method"));
        }

        private void assignTask(int splitNr, int linesNr)
        {
            int lstLine = splitNr * linesNr;
            int fstLine = lstLine - linesNr + 1;

            List<string> fileSplit = client.getFileSplit(fstLine, lstLine);
            List<KeyValuePair<string, string>> mapResult = mapSplit(fileSplit, mapperClass, mapperClassType);
            client.setMappingResult(mapResult, splitNr);
        }
    }
}
