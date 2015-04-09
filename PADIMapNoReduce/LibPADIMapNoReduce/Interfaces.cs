using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPADIMapNoReduce
{
  
    public interface IMapper {
        IList<KeyValuePair<string, string>> Map(string fileLine);
    }

    public interface IMapperTransfer {
        bool SendMapper(byte[] code, string className);
    }

    public interface IWorker : IMapperTransfer { }

    public interface IMaster : IMapperTransfer { }

    public interface IClient : IMapperTransfer { }


}
