using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Ammunition : IAmmunition
{
    protected Ammunition(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
        this.WearLevel = this.Weight * 100;
    }
    public string Name { get; private set; }

    public double WearLevel { get;  set; }

    public double Weight { get; set; }

    public void DecreaseWearLevel(double wearAmount)
    {
        
    }
}

