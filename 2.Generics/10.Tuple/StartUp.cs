using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string fullName = $"{firstInput[0]} {firstInput[1]}";
            string adress = firstInput[2];
            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, adress);
            Console.WriteLine(firstTuple.ToString());

            string[] secondInput = Console.ReadLine().Split();
            string name = secondInput[0];
            double amountOfBeer = double.Parse(secondInput[1]);
            Tuple<string, double> secondTuple = new Tuple<string, double>(name, amountOfBeer);
            Console.WriteLine(secondTuple.ToString());

            string[] thirdInput = Console.ReadLine().Split();
            int firtsInt = int.Parse(thirdInput[0]);
            double secondDouble = double.Parse(thirdInput[1]);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(firtsInt, secondDouble);
            Console.WriteLine(thirdTuple.ToString());
        }
    }
}
