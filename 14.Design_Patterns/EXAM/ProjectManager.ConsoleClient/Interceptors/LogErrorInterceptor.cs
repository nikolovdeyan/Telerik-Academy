using Ninject.Extensions.Interception;
using ProjectManager.Framework.Core.Commands.Contracts;
using ProjectManager.Framework.Core.Common.Contracts;

namespace ProjectManager.ConsoleClient.Interceptors
{
    class LogErrorInterceptor : IInterceptor
    {
        private readonly IValidator validator;

        public LogErrorInterceptor(IValidator validator)
        {
            this.validator = validator;
        }

        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();
        }
    }
}
