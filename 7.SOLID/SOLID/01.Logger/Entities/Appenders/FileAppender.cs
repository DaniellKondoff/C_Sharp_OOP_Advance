using System;
using _01.Logger.Enums;
using _01.Logger.Interfaces;

namespace _01.Logger.Entities.Appenders
{
   public class FileAppender : IAppender
    {
        private readonly ILayout layout;

        public FileAppender(ILayout layout)
        {
            this.layout = layout;
        }

        public LogFile File { get; internal set; }

        public ReportLevel ReportLevel { get; set; }

        public void Append(string timeStamp, string reportLevel, string message)
        {
            string formattedMsg = this.layout.FormatMessage(timeStamp, reportLevel, message);
            this.File.Write(formattedMsg);
        }
    }
}
