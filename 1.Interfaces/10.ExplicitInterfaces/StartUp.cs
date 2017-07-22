using _10.ExplicitInterfaces.Interfaces;
using _10.ExplicitInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExplicitInterfaces
{
    class StartUp
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            IList<Citizen> citizens = new List<Citizen>();

            while (inputLine != "End")
            {
                var tokens = inputLine.Split();
                Citizen citizen = new Citizen(tokens[0],tokens[1],int.Parse(tokens[2]));
                citizens.Add(citizen);
                inputLine = Console.ReadLine();
            }

            foreach (var citizen in citizens)
            {
                IResident resident = (IResident)citizen;
                IPerson person = (IPerson)citizen;
                Console.WriteLine(person.GetName());
                Console.WriteLine($"{resident.GetName()} {person.GetName()}");
            }
        }
    }
}
