using Ninject;
using ProjectManager.Framework.Core.Commands.Contracts;
using ProjectManager.Framework.Core.Common.Contracts;
using ProjectManager.Framework.Core.Common.Exceptions;

namespace ProjectManager.ConsoleClient.Container
{
    public class ServiceLocator : IServiceLocator
    {
        private readonly IKernel kernel;

        public ServiceLocator(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public ICommand GetCommand(string commandName)
        {
            try
            {
                return this.kernel.Get<ICommand>(commandName);
            }
            catch
            {
                throw new UserValidationException("No such command!");
            }
        }
    }
}
