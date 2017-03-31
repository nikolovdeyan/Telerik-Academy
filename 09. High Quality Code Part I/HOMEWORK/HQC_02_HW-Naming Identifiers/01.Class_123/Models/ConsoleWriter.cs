using System;

namespace Writer.Models
{
    internal class ConsoleWriter
    {
        private const int MaxLines = 6;

        public static void DisplayTrueOnConsole()
        {
            Instance writer = new Instance();

            writer.DisplayBooleanStringValueToConsole(true);
        }

        private class Instance
        {
            public void DisplayBooleanStringValueToConsole(bool boolValue)
            {
                string boolAsString = boolValue.ToString();

                Console.WriteLine(boolAsString);
            }
        }
    }
}