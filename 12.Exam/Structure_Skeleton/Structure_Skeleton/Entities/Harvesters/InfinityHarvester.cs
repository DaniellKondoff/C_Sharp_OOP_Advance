using System;

public class InfinityHarvester : Harvester
{
    private const int OreOutputDivider = 10;

    private double durability;

    public InfinityHarvester(int id, double oreOutput, double energyRequirement) : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput /= OreOutputDivider;
    }

    //public override double Durability
    //{
    //    get
    //    {
    //        return this.durability;
    //    }

    //    //protected set
    //    //{
    //    //    //this.durability = Math.Max(0, value);
    //    //        }
    //}

    public override double Durability
    {
        get
        {
            return base.Durability; 
        }

        protected set
        {
            base.Durability = Math.Max(0,value);
        }
    }
}