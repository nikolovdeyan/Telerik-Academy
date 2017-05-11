namespace ProjectManager.Core.Contracts
{
    /// <summary>Provides an engine to execute the application logic.</summary>
    public interface IEngine
    {
        /// <summary>Holds the IFileLogger instance used by the engine.</summary>
        IFileLogger Logger { get; set; }

        /// <summary>Holds the ICommandProcessor instance used by the engine.</summary>
        ICommandProcessor Processor { get; set; }

        /// <summary>Executes the start of the engine which can be terminated with a termination command.</summary>
        void Start();
    }
}