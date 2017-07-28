using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ComparingObjects
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            List<Person> people = new List<Person>();
            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];
                Person person = new Person(name, age, town);
                people.Add(person);
                input = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine())-1;

            Person comparedPerson = people[n];

            int equalPeople = 0;

            foreach (var person in people)
            {
                if (comparedPerson.CompareTo(person)==0)
                {
                    equalPeople++;
                }
            }

            if (equalPeople < 2)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPeople} {people.Count - equalPeople} {people.Count}");
            }
        }
    }
}
