using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Tesla : ICar,IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Batteries = battery;
    }

    public int Batteries
    {
        get;private set;
    }

    public string Color
    {
        get;private set;
    }

    public string Model
    {
        get;private set;
    }

    public string Start()
    {
        throw new NotImplementedException();
    }

    public string Stop()
    {
        throw new NotImplementedException();
    }
}

