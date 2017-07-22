using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Ferrari
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string driverName = Console.ReadLine();
            var car = new Ferrari(driverName);
            Console.WriteLine(car.ToString());

            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
            

        }
    }
}
