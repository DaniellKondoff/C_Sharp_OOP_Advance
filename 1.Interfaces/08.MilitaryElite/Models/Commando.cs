using _08.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, double salary, string cors, IList<IMission> missions)
            : base(id, firstName, lastName, salary, cors)
        {
            this.Missions = missions;
        }

        public IList<IMission> Missions
        {
            get; private set;
        }

        public void CompleteMission()
        {

        }

        public override string ToString()
        {
            var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
            sb.AppendLine("Missions:");
            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Missions)}");
            return sb.ToString().Trim();
        }
    }
}
