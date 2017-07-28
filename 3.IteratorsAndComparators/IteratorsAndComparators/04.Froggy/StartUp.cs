using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Froggy
{
    class StartUp
    {
        static void Main()
        {
            var inputStones = Console.ReadLine()
                .Split(new[] { ',',' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(inputStones);

            Console.WriteLine(string.Join(", ",lake));
        }
    }
}
