using _06.StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StrategyPattern.Comparators
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int nameLengthComparator = x.Name.Length.CompareTo(y.Name.Length);
            if (nameLengthComparator != 0)
            {
                return nameLengthComparator;
            }

            return x.Name.ToUpper()[0].CompareTo(y.Name.ToUpper()[0]);
        }
    }
}
