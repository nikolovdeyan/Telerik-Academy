using Bytes2you.Validation;
using ProjectManager.Common.Exceptions;
using ProjectManager.Core.Contracts;
using System;

namespace ProjectManager.Core
{
    internal class Engine : IEngine
    {
        internal const string TerminationCommand = "exit";
        internal const string ExitMessage = "Program terminated.";
        internal const string ErrorMessage = "Opps, something happened. :(";

        public Engine(IFileLogger logger, ICommandProcessor processor)
        {
            Guard.WhenArgument(logger, "Engine Logger provider").IsNull().Throw();

            Guard.WhenArgument(processor, "Engine Processor provider").IsNull().Throw();

            this.Logger = logger;

            this.Processor = processor;
        }

        public IFileLogger Logger { get; set; }

        public ICommandProcessor Processor { get; set; }

        public void Start()
        {
            while (true)
            {
                var inputLineString = Console.ReadLine();

                if (inputLineString.ToLower() == TerminationCommand)
                {
                    Console.WriteLine(ExitMessage);

                    break;
                }

                try
                {
                    var executionResult = this.Processor.Process(inputLineString);

                    Console.WriteLine(executionResult);
                }
                catch (UserValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ErrorMessage);

                    this.Logger.Error(ex.Message);
                }
            }
        }
    }
}