using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public enum Season
    {
        Spring, Summer, Autumn, Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ENUMS
            Season summer = Season.Summer;
            string[] names = Enum.GetNames(typeof(Season));
        }
    }
}
