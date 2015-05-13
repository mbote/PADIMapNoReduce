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
        void setClient(string clientAddress);
    }

    public interface IMaster : IMapperTransfer { }

    public interface IClient : IMapperTransfer {
        List<string> getFileSplit(int fstLine, int lstLine);
        void setMappingResult(IList<KeyValuePair<string, string>> mapResults, int splitNr);
    }


}
