using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split().ToArray();
            string[] webSites = Console.ReadLine().Split().ToArray();
            Smartphone smartphone = new Smartphone();

            foreach (var number in phoneNumbers)
            {
                Console.WriteLine(smartphone.Call(number));
            }
            foreach (var site in webSites)
            {

                Console.WriteLine(smartphone.Browse(site));
            }
        }
    }
}
