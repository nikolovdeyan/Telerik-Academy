using Bytes2you.Validation;
using ProjectManager.Framework.Core.Commands.Contracts;
using ProjectManager.Framework.Core.Common.Contracts;

namespace ProjectManager.Framework.Core.Commands.Factories
{
    public class CommandsFactory : ICommandsFactory
    {
        private const string VALIDATABLE = "validatable";

        private readonly IServiceLocator serviceLocator;

        public CommandsFactory(IServiceLocator serviceLocator)
        {
            Guard.WhenArgument(serviceLocator, "ServiceLocator").IsNull().Throw();
            this.serviceLocator = serviceLocator;
        }

        public IServiceLocator ServiceLocator
        {
            get
            {
                return this.serviceLocator;
            }
        }

        public ICommand GetCommandFromString(string commandName)
        {
            return this.ServiceLocator.GetCommand(commandName.ToLower()+VALIDATABLE); 
        }
    }
}
