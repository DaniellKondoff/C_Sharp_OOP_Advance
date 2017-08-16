using SofUniInjector.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SofUniInjector.Core.RegisteringModules
{
    public class AttributeRegisteringModule : AbbstractRegisteringModule
    {
        public AttributeRegisteringModule(Assembly assembly) : base(assembly)
        {
        }

        public override void Register(IDictionary<Type, Type> types, IDictionary<Type, object> objects)
        {
           IEnumerable<Type> decoratedTypes = this.Assembly.GetTypes()
                .Where(t => t.GetTypeInfo()
                .GetCustomAttributes<InjectionCandidateAttribute>().Any());

            foreach (Type decoratedImplementation in decoratedTypes)
            {
                foreach (Type abstraction in decoratedImplementation.GetInterfaces())
                {
                    types[abstraction] = decoratedImplementation;
                }
            }
        }
    }
}
