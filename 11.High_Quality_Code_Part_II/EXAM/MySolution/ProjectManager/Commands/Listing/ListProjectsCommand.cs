using ProjectManager.Commands.Abstract;
using ProjectManager.Commands.Contracts;
using ProjectManager.Common.Exceptions;
using ProjectManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManager.Commands.Listing
{
    public class ListProjectsCommand : ListingCommand, ICommand
    {
        internal const int CommandValidNumberOfParameters = 0;
        internal const string InvalidCommandParametersMessage = "Invalid command parameters count!";
        internal const string InvalidEmptyParametersMessage = "Some of the passed parameters are empty!";

        public ListProjectsCommand(IDatabase db)
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

            return string.Join(Environment.NewLine, this.Db.Projects);
        }
    }
}
