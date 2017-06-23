using ProjectManager.Framework.Core.Common.Contracts;
using System;

namespace ProjectManager.Framework.Core.Common.Providers
{
    public class ConsoleWriterProvider : IWriter
    {
        public void Write(object value)
        {
            Console.Write(value);
        }

        public void WriteLine(object value)
        {
            Console.WriteLine(value);
        }
    }
}
