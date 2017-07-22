using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericSwapMethodString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                box.InsertItems(value);
            }
            var swapPositions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            box.Swap(swapPositions[0], swapPositions[1]);
            box.PrintElements();
        }
    }
}
