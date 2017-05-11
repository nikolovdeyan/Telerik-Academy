using ProjectManager.Commands.Contracts;
using ProjectManager.Data;

namespace ProjectManager.Core.Factories
{
    /// <summary>Provides commands instanciation for the application.</summary>
    public interface ICommandsFactory
    {
        /// <summary>Holds the database instance for the application.</summary>
        Database Db { get; set; }

        /// <summary>Holds the instance of the IModelsFactory that manages the applicaiton models.</summary>
        IModelsFactory ModelsFactory { get; set; }

        /// <summary>Parses a string command into a ICommand</summary>
        /// <param name="commandAsString">An unparsed string containing the application command.</param>
        /// <returns>An ICommand instance of the parsed string command.</returns>
        ICommand CreateCommandFromString(string commandAsString);
    }
}