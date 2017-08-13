using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EventImplementation
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Dispatcher dispacher = new Dispatcher();
            Handler handler = new Handler();

            dispacher.NameChange += handler.OnDispatcherNameChange;

            while (name != "End")
            {
                dispacher.Name = name;
                name = Console.ReadLine();
            }
        }
    }
}
