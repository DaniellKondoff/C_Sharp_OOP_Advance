using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KingsGambit.Model
{
    public abstract class Soldier
    {
        public Soldier(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }

        public abstract void KingUnderAttack(object sender,EventArgs e);
    }
}
