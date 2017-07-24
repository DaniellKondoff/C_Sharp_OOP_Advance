using _08.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public Repair(int hours,string name)
        {
            this.Name = name;
            this.Hours = hours;
        }
        public int Hours
        {
            get;set;
        }

        public string Name
        {
            get;set;      
        }

        public override string ToString()
        {
            return $"Part Name: {this.Name} Hours Worked: {this.Hours}";
        }
    }
}
