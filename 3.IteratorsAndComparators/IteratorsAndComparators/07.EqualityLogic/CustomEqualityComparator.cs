using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.EqualityLogic
{
    public class CustomEqualityComparator : IEqualityComparer<Person>,IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var nameComparer = x.Name.CompareTo(y.Name);
            if (nameComparer != 0)
            {
                return nameComparer;
            }
            return x.Age.CompareTo(y.Age);
        }

        public bool Equals(Person x, Person y)
        {
            return x.Name == y.Name && x.Age == y.Age;
        }

        public int GetHashCode(Person obj)
        {
            return (obj.Name.GetHashCode() + (int)obj.Age.GetTypeCode());
        }

    }
}
