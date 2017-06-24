using Bytes2you.Validation;
using ProjectManager.Framework.Core.Common.Contracts;
using ProjectManager.Framework.Core.Common.Exceptions;
using System;

namespace ProjectManager.Framework.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ILogger logger;
        private readonly IProcessor processor;

        public Engine(IReader reader, IWriter writer, ILogger logger, IProcessor processor)
        {
            Guard.WhenArgument(reader, "Engine Logger provider").IsNull().Throw();
            Guard.WhenArgument(writer, "Engine Writer provider").IsNull().Throw();
            Guard.WhenArgument(logger, "Engine Logger provider").IsNull().Throw();
            Guard.WhenArgument(processor, "Engine Processor provider").IsNull().Throw();

            this.reader = reader;
            this.writer = writer;
            this.logger = logger;
            this.processor = processor;
        }

        public void Start()
        {
            while(true)
            {
                var commandLine = reader.ReadLine();

                if (commandLine.ToLower() == "exit")
                {
                    this.writer.WriteLine("Program terminated.");
                    break;
                }

                try
                {
                    var executionResult = this.processor.ProcessCommand(commandLine);
                    this.writer.WriteLine(executionResult);
                }
                catch (UserValidationException ex)
                {
                    this.logger.Error(ex.Message);
                    this.writer.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    this.writer.WriteLine("Opps, something happened. Check the log file :(");
                    this.logger.Error(ex.Message);
                }
            }
        }
    }
}
