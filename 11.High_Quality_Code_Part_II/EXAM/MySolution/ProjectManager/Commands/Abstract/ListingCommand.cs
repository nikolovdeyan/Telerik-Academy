using Bytes2you.Validation;
using ProjectManager.Data;

namespace ProjectManager.Commands.Abstract
{
    public abstract class ListingCommand
    {
        public ListingCommand(IDatabase database)
        {
            Guard.WhenArgument(database, "CreateProjectCommand Database").IsNull().Throw();

            this.Db = database;
        }

        public IDatabase Db { get; set; }
    }
}