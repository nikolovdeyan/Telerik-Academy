using Ninject;
using ProjectManager.Configs;
using ProjectManager.Framework.Core.Common.Contracts;
namespace ProjectManager.ConsoleClient
{
    public class Startup
    {
        public static void Main()
        {
            IKernel kernel = new StandardKernel(new NinjectManagerModule());

            IEngine engine = kernel.Get<IEngine>();
            engine.Start();
        }
    }
}
