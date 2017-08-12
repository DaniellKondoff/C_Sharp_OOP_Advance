using _01.Logger.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Interfaces
{
    public interface IAppender
    {
        void Append(string timeStamp, string reportLevel, string message);
        ReportLevel ReportLevel { get; }
    }
}
