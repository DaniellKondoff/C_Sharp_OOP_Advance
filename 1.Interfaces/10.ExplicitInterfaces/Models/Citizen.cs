using _10.ExplicitInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExplicitInterfaces.Models
{
    public class Citizen : IResident,IPerson
    {
        public Citizen(string name,string country,int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }
        public int Age
        {
            get;
        }

        public string Country
        {
            get;
        }

        public string Name
        {
            get;
        }

        string IResident.GetName()
        {
            return "Mr/Ms/Mrs";
        }
        string IPerson.GetName()
        {
            return this.Name;
        }
    }
}
