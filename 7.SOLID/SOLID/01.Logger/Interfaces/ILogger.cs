using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Interfaces
{
    public interface ILogger
    {
        void Error(string timeStamp,string message);
        void Info(string timeStamp,string message);
        void Fatal(string timeStamp,string message);
        void Critical(string timeStamp,string message);
        void Warn(string timeStamp,string message);
    }
}
