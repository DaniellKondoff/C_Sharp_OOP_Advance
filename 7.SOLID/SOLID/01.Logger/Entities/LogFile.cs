using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Entities
{
    public class LogFile
    {
        private const string DefaultFileName = "log.txt";
        private StringBuilder sb;

        public LogFile()
        {
            this.sb = new StringBuilder();
        }
        public int Size { get; private set; }

        private int GetLettersOnlySUm(string message)
        {
            return message
                .Where(c => char.IsLetter(c))
                .Sum(c => c);
        }

        public void Write(string formattedMsg)
        {
            this.sb.AppendLine(formattedMsg);
            File.AppendAllText(DefaultFileName, formattedMsg + Environment.NewLine);
            this.Size = this.GetLettersOnlySUm(formattedMsg);
        }
    }
}
