using _08.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, double salary, string cors,IList<IRepair> parts) 
            : base(id, firstName, lastName, salary, cors)
        {
            this.Parts = parts;
        }

        public IList<IRepair> Parts
        {
            get;
            private set;
        }

        public override string ToString()
        {
            var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
            sb.AppendLine("Repairs:");
            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Parts)}");
            return sb.ToString().Trim();
        }
    }
}
