using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BarracksFactory.Attrebutes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple =true)]
    public class InjectAttribute : Attribute
    {

    }
}
