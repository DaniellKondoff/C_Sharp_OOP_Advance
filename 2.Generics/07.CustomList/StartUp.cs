using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CustomList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CustomList<string> elements = new CustomList<string>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "Add":
                        elements.Add(input[1]);
                        break;
                    case "Print":
                        elements.Print();
                        break;
                    case "Remove":
                        elements.Remove(int.Parse(input[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(elements.Contains(input[1]));
                        break;
                    case "Swap":
                        int index1 = int.Parse(input[1]);
                        int index2 = int.Parse(input[2]);
                        elements.Swap(index1, index2);
                        break;
                    case "Greater":
                        Console.WriteLine(elements.CountGreaterThan(input[1]));
                        break;
                    case "Max":
                        Console.WriteLine(elements.Max());
                        break;
                    case "Min":
                        Console.WriteLine(elements.Min());
                        break;
                    case "Sort":
                        Sorter.Sort(elements);
                            break;
                }
                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
