using System;
using System.Collections.Generic;
using System.Text;

namespace PADIMapNoReduce
{
  
    public interface IMapper {
        IList<KeyValuePair<string, string>> Map(string fileLine);
    }

    public interface IMapperTransfer {
        bool SendMapper(byte[] code, string className);
    }

    public interface IWorker : IMapperTransfer {
        void setJobTracker(bool b);
    }

    public interface IMaster : IMapperTransfer { }

    public interface IClient : IMapperTransfer { }


}
