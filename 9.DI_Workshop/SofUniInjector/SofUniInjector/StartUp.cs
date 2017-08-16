using System;
using System.Collections.Generic;
using System.Linq;
using SofUniInjector.Core;
using SofUniInjector.Reposotires;
using SofUniInjector.Services;
using SofUniInjector.Core.RegisteringModules;
using System.Reflection;
using System.Resources;
using SofUniInjector.Resources;

namespace SofUniInjector
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ResourceManager rm = new ResourceManager("SofUniInjector.Resources.Vars", Assembly.GetEntryAssembly());

            var conteiner = new Container(
                typeof(Vars).FullName,
                Assembly.GetEntryAssembly(),
                new SingleImplementationModule(Assembly.GetEntryAssembly()),
                new ManuelRegisterModule().Register<ISoftUniReposotory,DefaultSoftUniReposotory>(),
                new AttributeRegisteringModule(Assembly.GetEntryAssembly())
                );
          
            var userService = conteiner.Get<IUserService>();
            userService.Rename();
        }
    }
}
