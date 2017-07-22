using _07.FoodShortage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FoodShortage.Models
{
    public abstract class Human : IBuyer
    {
        public Human(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Food = 0;
        }

        public string Name { get; set; }

        public int Age { get; set; }
        public int Food { get; set; }

        public abstract void BuyFood();
    }
}
