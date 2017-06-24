using ProjectManager.Framework.Core.Common.Contracts;
using System;

namespace ProjectManager.Framework.Core.Common.Providers
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
