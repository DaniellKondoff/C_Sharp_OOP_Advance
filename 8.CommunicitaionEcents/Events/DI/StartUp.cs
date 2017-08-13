using DI.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var number = random.Next(1, 100);
            //Lotary lotary = new Lotary();
            //Console.WriteLine(lotary.CheckForWin(number));
            //lotary.Number = number;
            Lotary lotary = new Lotary(number);
            Console.WriteLine(lotary.CheckForWin());

        }
    }
}
