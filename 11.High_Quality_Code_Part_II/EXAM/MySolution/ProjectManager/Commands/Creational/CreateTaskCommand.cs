using Bytes2you.Validation;
using ProjectManager.Commands.Abstract;
using ProjectManager.Commands.Contracts;
using ProjectManager.Common.Exceptions;
using ProjectManager.Core.Factories;
using ProjectManager.Data;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManager.Commands.Creational
{
    public class CreateTaskCommand : CreationCommand, ICommand
    {
        internal const int CommandValidNumberOfParameters = 4;
        internal const string SuccessfulTaskCreationMessage = "Successfully created a new task!";
        internal const string InvalidCommandParametersMessage = "Invalid command parameters count!";
        internal const string InvalidEmptyParametersMessage = "Some of the passed parameters are empty!";

        public CreateTaskCommand(IDatabase database, IModelsFactory factory)
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

            var projectId = this.Db.Projects[int.Parse(parameters[0])];

            var projectOwnerUserId = projectId.Users[int.Parse(parameters[1])];

            var task = this.CommandFactory.CreateTask(projectOwnerUserId, parameters[2], parameters[3]);

            projectId.Tasks.Add(task);

            return SuccessfulTaskCreationMessage;
        }
    }
}