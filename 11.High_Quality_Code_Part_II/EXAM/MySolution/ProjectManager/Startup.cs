using ProjectManager.Common;
using ProjectManager.Core;
using ProjectManager.Core.Factories;
using ProjectManager.Core.Providers;
using ProjectManager.Data;
using ProjectManager.Models;

namespace ProjectManager
{
    public class Startup
    {
        public static void Main()
        {
            var engine = new Engine(
                new FileLogger(), 
                new CommandProcessor(
                    new CommandsFactory(
                        new Database(), 
                        new ModelsFactory())));

            var engineHolder = new EngineProvider(engine);

            engineHolder.Start();
        }
    }
}