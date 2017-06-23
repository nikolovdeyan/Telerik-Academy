using Ninject;
using Ninject.Extensions.Factory;
using Ninject.Extensions.Interception.Infrastructure.Language;
using Ninject.Modules;
using ProjectManager.ConsoleClient.Configs;
using ProjectManager.ConsoleClient.Interceptors;
using ProjectManager.Data;
using ProjectManager.Framework.Core;
using ProjectManager.Framework.Core.Commands.Contracts;
using ProjectManager.Framework.Core.Commands.Creational;
using ProjectManager.Framework.Core.Commands.Decorators;
using ProjectManager.Framework.Core.Commands.Listing;
using ProjectManager.Framework.Core.Common.Contracts;
using ProjectManager.Framework.Core.Common.Providers;
using ProjectManager.Framework.Data;
using ProjectManager.Framework.Data.Factories;
using ProjectManager.Framework.Services;
using System;
using System.Linq;

namespace ProjectManager.Configs
{
    public class NinjectManagerModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IConfigurationProvider>().To<ConfigurationProvider>().InSingletonScope();
            IConfigurationProvider configurationProvider = Kernel.Get<IConfigurationProvider>();
            this.Bind<ILogger>().To<FileLogger>().InSingletonScope().WithConstructorArgument(configurationProvider.LogFilePath);

            Bind<IReader>().To<ConsoleReaderProvider>().InSingletonScope();
            Bind<IWriter>().To<ConsoleWriterProvider>().InSingletonScope();
            Bind<IEngine>().To<Engine>().InSingletonScope();
            var commandProcessorBinding = Bind<IProcessor>().To<CommandProcessor>().InSingletonScope();
            Bind<IModelsFactory>().To<ModelsFactory>().InSingletonScope();
            Bind<IValidator>().To<Validator>().InSingletonScope();
            Bind<IDatabase>().To<Database>().InSingletonScope();

            Bind<CreateProjectCommand>().ToSelf().InSingletonScope();
            Bind<CreateTaskCommand>().ToSelf().InSingletonScope();
            Bind<CreateUserCommand>().ToSelf().InSingletonScope();
            Bind<ListProjectDetailsCommand>().ToSelf().InSingletonScope();

            this.Bind<ICachingService>().To<CachingService>()
                .InSingletonScope()
                .WithConstructorArgument(configurationProvider.CacheDurationInSeconds);

            var listProjectsCommandBinding = Bind<ListProjectsCommand>()
                .ToSelf()
                .InSingletonScope().Intercept().With<CachingInterceptor>();

            var commandsFactoryBinding = Bind<ICommandsFactory>().ToFactory().InSingletonScope();

            // ICommand instantiation
            Bind<ICommand>().ToMethod(ctx =>
            {
                Type commandType = (Type)ctx.Parameters.Single().GetValue(ctx, null);
                return (ICommand)ctx.Kernel.Get(commandType);
            }).NamedLikeFactoryMethod((ICommandsFactory commandsFactory) => commandsFactory.GetCommand(null));
        }
    }
}
