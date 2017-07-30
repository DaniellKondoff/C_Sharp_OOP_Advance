using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TrafficLights
{
    public class TrafficLight
    {
        private TrafficMachine colorState;

        public TrafficLight(TrafficMachine colorState)
        {
            this.colorState = colorState;
        }

        public void ChangeState()
        {
            this.colorState = (TrafficMachine)(((int)this.colorState + 1) % Enum.GetNames(typeof(TrafficMachine)).Length);
        }

        public override string ToString()
        {
            return this.colorState.ToString();
        }
    }
}
