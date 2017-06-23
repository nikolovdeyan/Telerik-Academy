using System;

namespace ProjectManager.Framework.Core.Commands.Contracts
{
    public interface ICommandsFactory
    {
        // ICommands instantiation moved into the Ninject module using Ninject.Extensions.Factory
        ICommand GetCommand(Type type);
    }
}
