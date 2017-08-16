using SofUniInjector.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofUniInjector.Reposotires
{

    public class DefaultNeshtoSiReposotory : INeshtoSIInterface
    {
        public void Print()
        {
            Console.WriteLine("neshto si here");
        }
    }
}
