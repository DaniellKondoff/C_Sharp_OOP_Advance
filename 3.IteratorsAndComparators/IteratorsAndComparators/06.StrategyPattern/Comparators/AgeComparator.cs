using _06.StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StrategyPattern.Comparators
{
    public class AgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
