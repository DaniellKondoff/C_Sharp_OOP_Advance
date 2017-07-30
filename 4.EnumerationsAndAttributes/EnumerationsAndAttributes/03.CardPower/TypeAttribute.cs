using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CardPower
{
    public class TypeAttribute : Attribute
    {
        private const string TypeConst = "Enumeration";
        public TypeAttribute(string category,string description)
        {
            this.Type = TypeConst;
            this.Category = category;
            this.Description = description;
        }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Type = Enumeration, Description = {this.Description}.";
        }
    }

   
}
