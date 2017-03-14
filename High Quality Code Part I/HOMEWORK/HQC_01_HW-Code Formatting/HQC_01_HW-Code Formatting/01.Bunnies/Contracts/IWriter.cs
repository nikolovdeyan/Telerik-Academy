namespace Bunnies.Contracts
{
    /// <summary>
    /// A contract for a writer object
    /// </summary>
    public interface IWriter
    {
        /// <summary>
        /// Provides writing functionality for multiple lines of output
        /// </summary>
        /// <param name="message">A string containing the message to write</param>
        void Write(string message);

        /// <summary>
        /// Provides writing functionality for a single line of output
        /// </summary>
        /// <param name="message">A string containing the message to write</param>
        void WriteLine(string message);
    }
}
