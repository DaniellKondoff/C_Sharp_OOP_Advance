using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofUniInjector.Core.RegisteringModules
{
    public class ManuelRegisterModule : IregisteringModule
    {
        private readonly Dictionary<Type, Type> dependecies;
        private readonly Dictionary<Type, object> cache;

        public ManuelRegisterModule()
        {
            this.dependecies = new Dictionary<Type, Type>();
            this.cache = new Dictionary<Type, object>();
        }
        public ManuelRegisterModule Register<TAbstr, TImpl>() where TImpl : TAbstr
        {
            this.dependecies[typeof(TAbstr)] = typeof(TImpl);

            return this;
        }

        public void Register(IDictionary<Type, Type> types, IDictionary<Type, object> objects)
        {
            foreach (KeyValuePair<Type,Type> dependency in dependecies)
            {
                types[dependency.Key] = dependency.Value;
            }

            foreach (KeyValuePair<Type, object> cacheObj in this.cache)
            {
                objects[cacheObj.Key] = cacheObj.Value;
            }
        }
    }
}
