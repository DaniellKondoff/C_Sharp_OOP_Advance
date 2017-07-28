using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public Person(string name,int age,string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Town { get; private set; }

        public int CompareTo(Person otherPerson)
        {
            int nameCompare = this.Name.CompareTo(otherPerson.Name);
            if (nameCompare != 0)
            {
                return nameCompare;
            }
            int ageCompare = this.Age.CompareTo(otherPerson.Age);
            if (ageCompare != 0)
            {
                return ageCompare;
            }

            return this.Town.CompareTo(otherPerson.Town);
        }
    }
}
