using ProjectManager.Core.Factories;

namespace ProjectManager.Core.Contracts
{
    public interface ICommandProcessor
    {
        CommandsFactory CommandFactory { get; }

        string Process(string command);
    }
}