using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefineAnInterfaceIPerson
{
    public class Citizen : IPerson,IIdentifiable,IBirthable
    {
        public Citizen(string name,int age,string id,string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }
        public int Age
        {
            get;
        }

        public string Birthdate
        {
            get;

            set;
        }

        public string Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
        }
    }
}
