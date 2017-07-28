using _06.StrategyPattern.Comparators;
using _06.StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StrategyPattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SortedSet<Person> peopleByName = new SortedSet<Person>(new NameComparator());
            SortedSet<Person> peopleByAge = new SortedSet<Person>(new AgeComparator());

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                Person person = new Person(tokens[0], int.Parse(tokens[1]));
                peopleByName.Add(person);
                peopleByAge.Add(person);
            }

            foreach (var person in peopleByName)
            {
                Console.WriteLine(person);
            }

            foreach (var person in peopleByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}
