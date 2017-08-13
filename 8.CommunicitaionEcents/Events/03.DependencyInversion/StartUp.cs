using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StartUp
{
    static void Main(string[] args)
    {

        Dictionary<char, IStrategy> strategies = new Dictionary<char, IStrategy>()
        {
            { '+',new AdditionStrategy()},
            { '-',new SubtractionStrategy()},
            { '*',new MultiplyStrategy()},
            { '/',new DivideStrategy()}
        };

        PrimitiveCalculator calc = new PrimitiveCalculator(new AdditionStrategy(),strategies);

        string[] input = Console.ReadLine().Split();

        while (input[0] != "End")
        {
            if (input[0] == "mode")
            {
                calc.changeStrategy(char.Parse(input[1]));
            }
            else
            {
                Console.WriteLine(calc.performCalculation(int.Parse(input[0]), int.Parse(input[1])));
            }

            input = Console.ReadLine().Split();
        }
    }
}

