using System;

public abstract class Provider : IProvider
{
    private const int InitialDurability = 1000;

    public Provider(int id,double energyOutput)
    {
        this.ID = id;
        this.EnergyOutput = energyOutput;
        this.Durability = InitialDurability;
    }

    public int ID { get; }
    public double Durability { get; protected set; }

    public double EnergyOutput { get; protected set; }

 
    public void Broke()
    {
        //TODO
    }

    public double Produce()
    {
        return Double.MinValue; // TODO
    }

    public void Repair(double val)
    {
        //TODO
    }
}