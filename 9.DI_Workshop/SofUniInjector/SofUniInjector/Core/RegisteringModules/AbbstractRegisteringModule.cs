using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SofUniInjector.Core.RegisteringModules
{
    public abstract class AbbstractRegisteringModule : IregisteringModule
    {
        protected AbbstractRegisteringModule(Assembly assembly)
        {
            this.Assembly = assembly;
        }

        protected Assembly Assembly { get; }

        public abstract void Register(IDictionary<Type, Type> types, IDictionary<Type, object> objects);
       
    }
}
