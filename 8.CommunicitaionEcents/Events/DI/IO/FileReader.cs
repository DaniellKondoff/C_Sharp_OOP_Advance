using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.IO
{
    public class FileReader : IReader
    {
        public string ReadLine()
        {
            return File.ReadAllText("test.txt");
        }
    }
}
