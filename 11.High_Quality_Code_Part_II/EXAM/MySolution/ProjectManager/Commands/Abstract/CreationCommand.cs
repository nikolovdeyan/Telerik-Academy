using Bytes2you.Validation;
using ProjectManager.Core.Factories;
using ProjectManager.Data;

namespace ProjectManager.Commands.Abstract
{
    public abstract class CreationCommand
    {
        public CreationCommand(IDatabase database, IModelsFactory factory)
        {
            Guard.WhenArgument(database, "CreateProjectCommand Database").IsNull().Throw();
            Guard.WhenArgument(factory, "CreateProjectCommand ModelsFactory").IsNull().Throw();

            this.Db = database;

            this.CommandFactory = factory;
        }

        public IDatabase Db { get; set; }

        public IModelsFactory CommandFactory { get; set; }
    }
}