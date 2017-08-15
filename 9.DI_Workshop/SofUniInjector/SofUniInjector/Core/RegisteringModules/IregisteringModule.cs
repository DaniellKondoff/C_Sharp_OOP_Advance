using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofUniInjector.Core.RegisteringModules
{
    public interface IregisteringModule
    {
        void Register(IDictionary<Type,Type> types, IDictionary<Type,object> objects);
    }
}
