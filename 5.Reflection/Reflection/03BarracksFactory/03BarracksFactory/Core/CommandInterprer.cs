using _03BarracksFactory.Attrebutes;
using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03BarracksFactory.Core
{
    public class CommandInterprer : ICommandInterpreter
    {
        private const string CommandSuffix = "Command";
        private IRepository reposotory;
        private IUnitFactory unitFactory;

        public CommandInterprer(IRepository reposotory, IUnitFactory unitFactory)
        {
            this.reposotory = reposotory;
            this.unitFactory = unitFactory;
        }
        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            string commandCompleteName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName)+CommandSuffix;

            Type commandType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t=>t.Name == commandCompleteName);

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            object[] commandParams =
            {
                data
            };

            IExecutable currentCommand = (IExecutable)Activator.CreateInstance(commandType, commandParams);

            //Inject
            currentCommand = this.InjectDependecies(currentCommand);
            return currentCommand;
                         
        }

        private IExecutable InjectDependecies(IExecutable currentCommand)
        {
            FieldInfo[] commandfields = currentCommand.GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(f => f.GetCustomAttributes<InjectAttribute>() != null)
                .ToArray();

            FieldInfo[] interpreterFields = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo commandField in commandfields)
            {
                FieldInfo interpretefField = interpreterFields.First(f => f.FieldType == commandField.FieldType);
                object valueToInject = interpretefField.GetValue(this);
                commandField.SetValue(currentCommand,valueToInject);
            }

            return currentCommand;
        }
    }
}
