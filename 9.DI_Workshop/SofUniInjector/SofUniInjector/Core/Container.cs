namespace SofUniInjector.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using SofUniInjector.Reposotires;
    using SofUniInjector.Services;
    using RegisteringModules;
    using System.Resources;

    public class Container
    {
        private readonly Dictionary<Type, Type> dependecies;
        private readonly Dictionary<Type, object> cache;
        private readonly ResourceManager resouceManager;

        public Container(string resFile, Assembly assembly,params IregisteringModule[] modules)
        {
            this.dependecies = new Dictionary<Type, Type>();
            this.cache = new Dictionary<Type, object>();
            this.resouceManager = new ResourceManager(resFile, assembly);
            this.InvokeModules(modules);
        }

        private void InvokeModules(IregisteringModule[] modules)
        {
            foreach (IregisteringModule module in modules)
            {
                module.Register(this.dependecies, this.cache);
            }
        }



        public T Get<T>()
        {
            var interfaceType = typeof(T);
            return (T)this.Get(interfaceType);
        }

        private object Get(Type interfaceType)
        {

            if (this.cache.ContainsKey(interfaceType))
            {
                return this.cache[interfaceType];
            }

            Type concreteType = this.dependecies[interfaceType];
            var ctorInfo = concreteType.GetConstructors().FirstOrDefault();
            ParameterInfo[] args = ctorInfo.GetParameters();

            List<object> argsList = new List<object>();

            foreach (ParameterInfo arg in args)
            {
                if (arg.ParameterType.GetTypeInfo().IsPrimitive)
                {
                    string key = concreteType.FullName + "_" + arg.Name;
                    object value = this.resouceManager.GetString(key);
                    object castedValue = Convert.ChangeType(value, arg.ParameterType);
                    argsList.Add(castedValue);
                }
                else
                {
                    Type argType = arg.ParameterType;
                    object obj = this.Get(argType);
                    argsList.Add(obj);
                }

            }

            object objToCache =  ctorInfo.Invoke(argsList.ToArray());
            this.cache[interfaceType] = objToCache;

            return objToCache;
        }
    }
}
