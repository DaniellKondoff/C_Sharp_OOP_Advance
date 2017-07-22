using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FoodShortage.Models
{
    public class Citizen : Human
    {
        public Citizen(string name, int age, string id, string birthdate) 
            : base(name, age)
        {
            this.Id = id;
            this.BirthDate = birthdate;
        }

        public string Id { get; set; }

        public string BirthDate { get; set; }

        public override void BuyFood()
        {
            base.Food += 10;
        }
    }
}
