using Bytes2you.Validation;
using ProjectManager.Framework.Core.Commands.Contracts;
using ProjectManager.Framework.Data;
using ProjectManager.Framework.Data.Factories;

namespace ProjectManager.Framework.Core.Commands.Abstracts
{
    public abstract class CreationalCommand : Command, ICommand
    {
        protected readonly IModelsFactory Factory;
        protected readonly IDatabase database;

        public CreationalCommand(IModelsFactory factory, IDatabase database)
            :base(database)
        {
            Guard.WhenArgument(factory, "CreateProjectCommand ModelsFactory").IsNull().Throw();
            this.Factory = factory;
            this.database = database;
        }
    }
}
