using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Threeuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string fullName = $"{firstInput[0]} {firstInput[1]}";
            string adress = firstInput[2];
            string town = firstInput[3];
            Threeuple<string, string, string> firstTuple = new Threeuple<string, string, string>(fullName, adress, town);
            Console.WriteLine($"{firstTuple.Item1} -> {firstTuple.Item2} -> {firstTuple.Item3}");

            string[] secondInput = Console.ReadLine().Split();
            string name = secondInput[0];
            double amountOfBeer = double.Parse(secondInput[1]);
            bool drinkOrNot;
            if (secondInput[2] == "drunk")
            {
                drinkOrNot = true;
            }
            else
            {
                drinkOrNot = false;
            }
            Threeuple<string, double, bool> secondThreuple = new Threeuple<string, double, bool>(name, amountOfBeer, drinkOrNot);
            Console.WriteLine($"{secondThreuple.Item1} -> {secondThreuple.Item2} -> {secondThreuple.Item3}");

            string[] thirdInput = Console.ReadLine().Split();
            string firtsStr = thirdInput[0];
            double accountBalance = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];
            Threeuple<string, double, string> thirdTulip = new Threeuple<string, double, string>(firtsStr, accountBalance, bankName);
            Console.WriteLine($"{thirdTulip.Item1} -> {thirdTulip.Item2} -> {thirdTulip.Item3}");
        }
    }
}
