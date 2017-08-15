using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofUniInjector.Reposotires
{
    public class DefaultPaymentReposotory : IPaymentReposotory
    {
        public void Pay()
        {
            Console.WriteLine("No Payments :(");
        }
    }
}
