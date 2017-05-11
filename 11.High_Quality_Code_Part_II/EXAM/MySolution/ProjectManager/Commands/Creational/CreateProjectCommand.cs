using Bytes2you.Validation;
using ProjectManager.Commands.Abstract;
using ProjectManager.Commands.Contracts;
using ProjectManager.Common.Exceptions;
using ProjectManager.Core.Factories;
using ProjectManager.Data;
using ProjectManager.Models.Enums;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManager.Commands.Creational
{
    public class CreateProjectCommand : CreationCommand, ICommand
    {
        internal const int CommandValidNumberOfParameters = 4;
        internal const string SuccessfulProjectCreationMessage = "Successfully created a new project!";
        internal const string InvalidCommandParametersMessage = "Invalid command parameters count!";
        internal const string InvalidEmptyParametersMessage = "Some of the passed parameters are empty!";
        internal const string InvalidProjectAlreadyExistsMessage = "A project with that username already exists!";

        public CreateProjectCommand(IDatabase database, IModelsFactory factory)
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

            if (this.Db.Projects.Any(x => x.Name == parameters[0]))
            {
                throw new UserValidationException(InvalidProjectAlreadyExistsMessage);
            }

            // var project = this.CommandFactory.CreateProject(parameters[0], parameters[1], parameters[2], (ProjectState)int.Parse(parameters[3]));
            var project = this.CommandFactory.CreateProject(parameters[0], parameters[1], parameters[2], parameters[3]);

            this.Db.Projects.Add(project);

            return SuccessfulProjectCreationMessage;
        }
    }
}