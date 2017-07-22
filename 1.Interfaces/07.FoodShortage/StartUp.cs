using _07.FoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FoodShortage
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] humanInfo = Console.ReadLine().Split(' ');

                string name = humanInfo[0];
                int age = int.Parse(humanInfo[1]);

                if (humanInfo.Length > 3)
                {
                    string id = humanInfo[2];
                    string birthdate = humanInfo[3];
                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    humans.Add(citizen);
                }
                else
                {
                    string group = humanInfo[2];
                    Rabel rebel = new Rabel(name, age, group);
                    humans.Add(rebel);
                }
            }

            string byuer = Console.ReadLine();
            int totalFood = 0;
            while (byuer != "End")
            {
                humans.Find(h => h.Name == byuer)?.BuyFood();
                //if (humanByer!=null)
                //{
                //    humanByer.BuyFood();
                //}
                byuer = Console.ReadLine();
            }

            foreach (var human in humans)
            {
                totalFood += human.Food;
            }
            Console.WriteLine(totalFood);
        }
    }
}
