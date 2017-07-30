using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TrafficLights
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] inputSignals = Console.ReadLine().Split();
            List<TrafficLight> allTraficLights = new List<TrafficLight>();

            var lights = Enum.GetNames(typeof(TrafficMachine));
            int n = int.Parse(Console.ReadLine());

            foreach (var signal in inputSignals)
            {
                TrafficMachine initialColorState = (TrafficMachine)Enum.Parse(typeof(TrafficMachine), signal);
                allTraficLights.Add(new TrafficLight(initialColorState));
            }

            for (int i = 0; i < n; i++)
            {
                foreach (var trafficLight in allTraficLights)
                {
                    trafficLight.ChangeState();
                }
                Console.WriteLine(string.Join(" ",allTraficLights));
            }

            
        }
    }
}
