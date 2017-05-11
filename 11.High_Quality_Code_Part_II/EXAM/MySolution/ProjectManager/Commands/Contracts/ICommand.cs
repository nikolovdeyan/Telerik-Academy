using System.Collections.Generic;

namespace ProjectManager.Commands.Contracts
{
    public interface ICommand
    {
        string Execute(List<string> parameters);
    }
}