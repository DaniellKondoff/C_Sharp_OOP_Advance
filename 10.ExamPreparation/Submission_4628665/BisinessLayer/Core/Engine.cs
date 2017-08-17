using RecyclingStation.BisinessLayer.Contracts.Core;
using RecyclingStation.BisinessLayer.Contracts.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BisinessLayer.Core
{
    public class Engine : IEngine
    {
        private const string TerminatingCommand = "TimeToRecycle";
        private IReader reader;
        private IWriter writer;
        private IRecyclingStation recyclingStation;
        private readonly MethodInfo[] RecyclingStationMethods;


        public Engine(IReader reader, IWriter writer, IRecyclingStation recyclingStation)
        {
            this.Redaer = reader;
            this.Writer = writer;
            this.RecyclingStation = recyclingStation;
            this.RecyclingStationMethods = this.RecyclingStation.GetType().GetMethods();
        }

        private IReader Redaer
        {
            get { return this.reader; }
            set { this.reader = value; }
        }

        private IWriter Writer
        {
            get { return this.writer; }
            set { this.writer = value; }
        }

        public IRecyclingStation RecyclingStation
        {
            get
            {
                return recyclingStation;
            }

            set
            {
                recyclingStation = value;
            }
        }

        private string[] SplitStringByChar(string toSplit, params char[] toSplitBy)
        {
            return toSplit.Split(toSplitBy, StringSplitOptions.RemoveEmptyEntries);
        }
        public void Run()
        {
            string inputLine;
            while ((inputLine = this.reader.ReadLine()) != TerminatingCommand)
            {
                string[] commandArgs = this.SplitStringByChar(inputLine, ' ');
                string methodName = commandArgs[0];
                string[] methodNonParsedParams = default(string[]);
                if (commandArgs.Length ==2)
                {
                    methodNonParsedParams= this.SplitStringByChar(commandArgs[1], '|');
                }

                MethodInfo methodToInvoke = this.RecyclingStationMethods.FirstOrDefault(m => m.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase));

                ParameterInfo[] methodParams = methodToInvoke.GetParameters();

                object[] parsedParams = new object[methodParams.Length];
                for (int currentConvertion = 0; currentConvertion < methodParams.Length; currentConvertion++)
                {
                    Type currentParamType = methodParams[currentConvertion].ParameterType;

                    string toConvert = methodNonParsedParams[currentConvertion];

                    parsedParams[currentConvertion] = Convert.ChangeType(toConvert, currentParamType);
                }

                object result = methodToInvoke.Invoke(this.RecyclingStation, parsedParams);

                this.Writer.GatherOutput(result.ToString());
            }
            this.Writer.WriteGatherOutput();

        }
    }
}
