using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericCountMethodString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //StringCamperar(n);
            DoubleComperaring(n);
        }

        private static void DoubleComperaring(int n)
        {
            Box<double> box = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                double value = double.Parse(Console.ReadLine());
                box.InsertItems(value);
            }

            var comperarCmd = double.Parse(Console.ReadLine());
            box.Comper(comperarCmd);
            Console.WriteLine(box.GetCounter);
        }

        private static void StringCamperar(int n)
        {
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                box.InsertItems(value);
            }

            var comperarString = Console.ReadLine();
            box.Comper(comperarString);
            Console.WriteLine(box.GetCounter);
        }
    }
}
