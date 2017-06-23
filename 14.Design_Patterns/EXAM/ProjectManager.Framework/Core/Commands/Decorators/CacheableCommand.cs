using Bytes2you.Validation;
using ProjectManager.Framework.Core.Commands.Contracts;
using ProjectManager.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Framework.Core.Commands.Decorators
{
    public class CacheableCommand : ICommand
    {
        private readonly ICacheableCommand commandDecorated;
        private readonly ICachingService cachingService;

        public CacheableCommand(ICacheableCommand command, ICachingService cachingService)
        {
            Guard.WhenArgument(command, "Cacheable command").IsNull().Throw();
            Guard.WhenArgument(cachingService, "Caching service").IsNull().Throw();

            this.commandDecorated = command;
            this.cachingService = cachingService;
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

        public void CacheCommand()
        {
        }
    }
}