using ProjectManager.Commands.Contracts;
using ProjectManager.Commands.Creational;
using ProjectManager.Commands.Listing;
using ProjectManager.Common.Exceptions;
using ProjectManager.Data;

namespace ProjectManager.Core.Factories
{
    public class CommandsFactory : ICommandsFactory
    {
        internal const string InvalidCommandString = "The passed command is not valid!";

        public CommandsFactory(Database db, IModelsFactory modelsFactory)
        {
            this.Db = db;

            this.ModelsFactory = modelsFactory;
        }

        public Database Db { get; set; }

        public IModelsFactory ModelsFactory { get; set; }

        public ICommand CreateCommandFromString(string commandAsString)
        {
            var command = commandAsString.ToLower();

            switch (command)
            {
                case "createproject": return new CreateProjectCommand(this.Db, this.ModelsFactory);
                case "createuser": return new CreateUserCommand(this.Db, this.ModelsFactory);
                case "createtask": return new CreateTaskCommand(this.Db, this.ModelsFactory);
                case "listprojects": return new ListProjectsCommand(this.Db);
                case "listprojectdetails": return new ListProjectDetailsCommand(this.Db);
                default: throw new UserValidationException(InvalidCommandString);
            }
        }
    }
}