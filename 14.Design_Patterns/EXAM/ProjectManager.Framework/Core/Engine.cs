using Bytes2you.Validation;
using ProjectManager.Framework.Core.Common.Contracts;
using ProjectManager.Framework.Core.Common.Exceptions;
using System;

namespace ProjectManager.Framework.Core
{
    public class Engine : IEngine
    {
        private readonly ILogger logger;
        private readonly IProcessor processor;
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(IReader reader, IWriter writer, ILogger logger, IProcessor processor)
        {
            Guard.WhenArgument(reader, "Engine Logger provider").IsNull().Throw();
            Guard.WhenArgument(writer, "Engine Processor provider").IsNull().Throw();
            Guard.WhenArgument(logger, "Engine Processor provider").IsNull().Throw();
            Guard.WhenArgument(processor, "Engine Processor provider").IsNull().Throw();

            this.reader = reader;
            this.writer = writer;
            this.logger = logger;
            this.processor = processor;
        }

        public ILogger Logger
        {
            get
            {
                return this.logger;
            }
        }

        public IProcessor Processor
        {
            get
            {
                return this.processor;
            }
        }

        public IReader Reader
        {
            get
            {
                return this.reader;
            }
        }

        public IWriter Writer
        {
            get
            {
                return this.writer;
            }
        }

        public void Start()
        {
            while(true)
            {
                var commandLine = Reader.ReadLine();

                if (commandLine.ToLower() == "exit")
                {
                    this.Writer.WriteLine("Program terminated.");
                    break;
                }

                try
                {
                    var executionResult = this.processor.ProcessCommand(commandLine);
                    this.Writer.WriteLine(executionResult);
                }
                catch (UserValidationException ex)
                {
                    this.Logger.Error(ex.Message);
                    this.Writer.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    this.Writer.WriteLine("Opps, something happened. Check the log file :(");
                    this.Logger.Error(ex.Message);
                }
            }
        }
    }
}
