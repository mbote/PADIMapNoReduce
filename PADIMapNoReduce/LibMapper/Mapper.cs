using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PADIMapNoReduce;



namespace LibMapper
{
    public class Mapper:IMapper
    {
        public IList<KeyValuePair<string, string>> Map(string fileLine)
        {
            IList<KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>();
            result.Add(new KeyValuePair<string, string>("testKey1", fileLine));
            result.Add(new KeyValuePair<string, string>("testKey2", "anotherValue"));
            return result;
        }
    }
}

