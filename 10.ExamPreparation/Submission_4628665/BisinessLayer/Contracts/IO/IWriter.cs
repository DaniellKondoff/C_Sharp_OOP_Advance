using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BisinessLayer.Contracts.IO
{
    public interface IWriter
    {
        void GatherOutput(string outputToGather);
        void WriteGatherOutput();
    }
}
