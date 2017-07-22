using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Ferrari
{
    public class Ferrari : ICar
    {

        public Ferrari(string driver)
        {
            this.Driver = driver;
            this.Model = "488-Spider";
        }

        public string Driver { get; private set; }
        public string Model { get; private set; }

        public string Break()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Break()}/{this.Gas()}/{this.Driver}";
        }
    }
}
