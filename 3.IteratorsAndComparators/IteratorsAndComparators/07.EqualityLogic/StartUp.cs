using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.EqualityLogic
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SortedSet<Person> peopleSortList = new SortedSet<Person>(new CustomEqualityComparator());
            HashSet<Person> peopleHash = new HashSet<Person>(new CustomEqualityComparator());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                Person person = new Person(tokens[0], int.Parse(tokens[1]));
                peopleSortList.Add(person);
                peopleHash.Add(person);          
            }

            Console.WriteLine(peopleSortList.Count);
            Console.WriteLine(peopleHash.Count);
        }
    }
}
