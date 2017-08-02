using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class SimpleClass : IComparable<int>
    {
        private int simpleInt;
        private string name;
        public SimpleClass(string name)
        {
            this.Name = name;

        }

        public SimpleClass() : this("SomeText")
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
           }
        }
        public int CompareTo(int other)
        {
            throw new NotImplementedException();
        }


    }
}
