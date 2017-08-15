using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SofUniInjector.Core.RegisteringModules
{
    public class SingleImplementationModule : IregisteringModule
    {
        private Assembly Assembly { get; }
        public SingleImplementationModule(Assembly assembly)
        {
            this.Assembly = assembly;
        }

        public void Register(IDictionary<Type, Type> types, IDictionary<Type, object> objects)
        {
            Type[] allTypes = this.Assembly.GetTypes();
            Type[] abstractions = allTypes.Where(t => t.GetTypeInfo().IsInterface)
                .Where(t => t.GetTypeInfo().IsAbstract).ToArray();

            Type[] concreteTypes = allTypes.Except(abstractions).ToArray();

            foreach (var abstraction in abstractions)
            {
                Type[] implementations = concreteTypes.Where(t => t.GetInterfaces().Contains(abstraction)).ToArray();

                if (implementations.Length != 1)
                {
                    continue;
                }
                Type singleImplementation = implementations[0];
                types[abstraction] = singleImplementation;
            }
        }
    }
}
