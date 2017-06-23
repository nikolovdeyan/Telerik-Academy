using System.Linq;

using Bytes2you.Validation;
using ProjectManager.Framework.Core.Common.Contracts;
using ProjectManager.Framework.Core.Common.Exceptions;
using ProjectManager.Framework.Core.Commands.Contracts;
using System;
using System.Reflection;

namespace ProjectManager.Framework.Core.Common.Providers
{
    public class CommandProcessor : IProcessor  
    {
        private readonly ICommandsFactory commandsFactory;

        public CommandProcessor(ICommandsFactory commandsFactory)
        {
            Guard.WhenArgument(commandsFactory, "CommandProcessor CommandsFactory").IsNull().Throw();

            this.commandsFactory = commandsFactory;
        }

        public ICommandsFactory CommandsFactory
        {
            get
            {
                return this.commandsFactory;
            }
        }

        public string ProcessCommand(string commandLine)
        {
            if (string.IsNullOrWhiteSpace(commandLine))
            {
                throw new UserValidationException("No command has been provided!");
            }

            var commandName = commandLine.Split(' ')[0];
            var commandParameters = commandLine
                .Split(' ')
                .Skip(1)
                .ToList();

            var commandTypeInfo = this.FindCommand(commandName);
            var command = this.CommandsFactory.GetCommand(commandTypeInfo);
            return command.Execute(commandParameters);
        }

        private TypeInfo FindCommand(string commandName)
        {
            var currentAssembly = this.GetType().GetTypeInfo().Assembly;
            var commandTypeInfo = currentAssembly.DefinedTypes
                .Where(type => type.ImplementedInterfaces.Any(inter => inter == typeof(ICommand)))
                .Where(type => type.Name.ToLower().Contains(commandName.ToLower()))
                .SingleOrDefault();

            if (commandTypeInfo == null)
            {
                throw new ArgumentException("The passed command is not found!");
            }

            return commandTypeInfo;
        }
    }
}
