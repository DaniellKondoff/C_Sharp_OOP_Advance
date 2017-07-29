using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CoffeeMachine
{
    private List<CoffeeType> coffeesSold = new List<CoffeeType>();
    private int coins;

    public CoffeeMachine()
    {
        this.coffeesSold = new List<CoffeeType>();
    }
    public IEnumerable<CoffeeType> CoffeesSold { get { return this.coffeesSold; } }

    public void BuyCoffee(string size, string type)
    {
        CoffeeType coffeeType =
                        (CoffeeType)Enum.Parse(typeof(CoffeeType), type);
        CoffeePrice coffeePrice =
                           (CoffeePrice)Enum.Parse(typeof(CoffeePrice), size);

        if (this.coins >= (int)coffeePrice)
        {
            this.coffeesSold.Add(coffeeType);
            this.coins = 0;
        }
    }
    public void InsertCoin(string coin)
    {
        Coin rem = (Coin)Enum.Parse(typeof(Coin),coin);
        this.coins += (int)rem;
    }

}

