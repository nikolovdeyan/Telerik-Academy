using ProjectManager.Framework.Core.Commands.Contracts;
using ProjectManager.Framework.Core.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Framework.Core.Commands.Decorators
{
    public class ValidatableCommand : ICommand, IValidatableCommand
    {
        private readonly ICommand command;
        private readonly IValidator validator;

        public ValidatableCommand(ICommand command, IValidator validator)
        {
            this.command = command;
            this.validator = validator;
        }

        public int ParameterCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Execute(IList<string> parameters)
        {
            throw new NotImplementedException();
        }

        public void Validate(ICommand command)
        {
            this.validator.Validate(command);
        }
    }
}
