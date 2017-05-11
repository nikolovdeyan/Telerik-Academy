using ProjectManager.Core.Contracts;
using ProjectManager.Core.Factories;
using System.Linq;

namespace ProjectManager.Common
{
    public class CommandProcessor : ICommandProcessor
    {
        public CommandProcessor(CommandsFactory factory)
        {
            this.CommandFactory = factory;
        }

        public CommandsFactory CommandFactory { get; private set; }

        public string Process(string commandLine)
        {
            if (string.IsNullOrWhiteSpace(commandLine))
            {
                throw new Exceptions.UserValidationException("No command has been provided!");
            }

            var command = this.CommandFactory.CreateCommandFromString(commandLine.Split(' ')[0]);
            return command.Execute(commandLine.Split(' ').Skip(1).ToList());
        }
    }
}