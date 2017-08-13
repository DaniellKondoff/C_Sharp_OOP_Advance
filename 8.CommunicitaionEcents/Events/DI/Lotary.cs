using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class Lotary
    {
        public Lotary(int number)
        {
            this.Number = number;
        }

        public int Number { get; private set; }
        public string CheckForWin()
        {

            if (Number < 20)
            {
                return "Sorry You Loseee";
            }
            else if (Number > 20 && 80 < Number)
            {
                return "You can have a new free try";
            }
            else
            {
                return "You Win!!!!!!!";
            }
        }
    }
}
