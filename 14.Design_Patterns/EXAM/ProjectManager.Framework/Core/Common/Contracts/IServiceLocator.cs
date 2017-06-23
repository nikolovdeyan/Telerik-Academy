using ProjectManager.Framework.Core.Commands.Contracts;

namespace ProjectManager.Framework.Core.Common.Contracts
{
    public interface IServiceLocator
    {
        ICommand GetCommand(string commandName);
    }
}
