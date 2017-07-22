using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BorderControl
{
    public class Robot : ISerial
    {
        public Robot(string model,string id)
        {
            this.Model = model;
            this.Id = id;
        }
        public string Model { get; set; }
        public string Id
        {
            get; private set;
        }
    }
}
