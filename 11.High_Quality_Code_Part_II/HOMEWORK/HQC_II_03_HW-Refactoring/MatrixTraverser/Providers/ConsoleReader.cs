using MatrixTraverser.Contracts;
using System;

namespace MatrixTraverser.Providers
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
