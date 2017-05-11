using ProjectManager.Commands.Abstract;
using ProjectManager.Commands.Contracts;
using ProjectManager.Common.Exceptions;
using ProjectManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManager.Commands.Listing
{
    public class ListProjectDetailsCommand : ListingCommand, ICommand
    {
        internal const int CommandValidNumberOfParameters = 1;
        internal const string InvalidCommandParametersMessage = "Invalid command parameters count!";
        internal const string InvalidEmptyParametersMessage = "Some of the passed parameters are empty!";

        public ListProjectDetailsCommand(IDatabase db)
            : base(db)
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

            return string.Join(Environment.NewLine, projectId);
        }
    }
}