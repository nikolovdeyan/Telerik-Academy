using Ninject.Extensions.Interception;
using ProjectManager.Framework.Core.Commands.Contracts;
using ProjectManager.Framework.Core.Common.Contracts;
using ProjectManager.Framework.Services;

namespace ProjectManager.ConsoleClient.Interceptors
{
    public class CachingInterceptor : IInterceptor
    {
        private readonly ICachingService cachingService;

        public CachingInterceptor(ICachingService cachingService)
        {
            this.cachingService = cachingService;
        }

        public void Intercept(IInvocation invocation)
        {
            // this.writer.WriteLine($"Calling method {invocation.Request.Method.Name} of type {invocation.Request.Method.DeclaringType.Name}...");
            // this.cachingService.AddCacheValue(className, methodName, value);
            invocation.Proceed();
        }
    }
}