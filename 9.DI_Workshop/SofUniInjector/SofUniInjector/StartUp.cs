using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SofUniInjector.Core;
using SofUniInjector.Reposotires;
using SofUniInjector.Services;
using SofUniInjector.Core.RegisteringModules;
using System.Reflection;

namespace SofUniInjector
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            var conteiner = new Container(
                new SingleImplementationModule(Assembly.GetEntryAssembly()),
                new ManuelRegisterModule().Register<ISoftUniReposotory,DefaultSoftUniReposotory>()
                );
          
            var userService = conteiner.Get<IUserService>();
            userService.Rename();
        }
    }
}
