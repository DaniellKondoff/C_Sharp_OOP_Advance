using RecyclingStation.BisinessLayer.Contracts.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BisinessLayer.IO
{
    public class ConsoleWriter : IWriter
    {
        private StringBuilder outputGatherer;

        public ConsoleWriter() : this(new StringBuilder())
        {

        }
        public ConsoleWriter(StringBuilder outputGatherer)
        {
            this.OutputGatherer = outputGatherer;
        }

        public StringBuilder OutputGatherer
        {
            get { return this.outputGatherer; }

            private set { this.outputGatherer = value; }
        }

        public void GatherOutput(string outputToGather)
        {
            this.OutputGatherer.AppendLine(outputToGather);
        }

        public void WriteGatherOutput()
        {
            Console.WriteLine(this.OutputGatherer);
        }
    }
}
