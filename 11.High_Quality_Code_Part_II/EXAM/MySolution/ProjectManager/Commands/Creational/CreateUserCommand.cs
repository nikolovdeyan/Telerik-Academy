using ProjectManager.Commands.Abstract;
using ProjectManager.Commands.Contracts;
using ProjectManager.Common.Exceptions;
using ProjectManager.Core.Factories;
using ProjectManager.Data;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManager.Commands.Creational
{
    public class CreateUserCommand : CreationCommand, ICommand
    {
        internal const int CommandValidNumberOfParameters = 3;
        internal const string SuccessfulUserCreationMessage = "Successfully created a new user!";
        internal const string InvalidCommandParametersMessage = "Invalid command parameters count!";
        internal const string InvalidEmptyParametersMessage = "Some of the passed parameters are empty!";
        internal const string InvalidUserAlreadyExistsMessage = "A user with that username already exists!";

        public CreateUserCommand(IDatabase database, IModelsFactory factory)
            : base(database, factory)
        {
        }

        public string Execute(List<string> parameters)
        {
            if (parameters.Count != CommandValidNumberOfParameters)
            {
                throw new UserValidationException(InvalidCommandParametersMessage);
            }

            if (parameters.Any(x => x == string.Empty))
            {
                throw new UserValidationException(InvalidEmptyParametersMessage);
            }

            if (this.Db.Projects[int.Parse(parameters[0])].Users.Any() && 
                this.Db.Projects[int.Parse(parameters[0])].Users.Any(x => x.UserName == parameters[1]))
            {
                throw new UserValidationException(InvalidUserAlreadyExistsMessage);
            }

            var newUser = this.CommandFactory.CreateUser(parameters[2], parameters[1]);

            this.Db.Projects[int.Parse(parameters[0])]
                .Users
                .Add(newUser);

            return SuccessfulUserCreationMessage;
        }
    }
}