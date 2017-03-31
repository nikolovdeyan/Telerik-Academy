using Writer.Models;

namespace Writer
{
    public class StartUp
    {
        public static void Main()
        {
            const string EndLoopCommand = "";

            while (System.Console.ReadLine() != EndLoopCommand)
            {
                ConsoleWriter.DisplayTrueOnConsole();
            }
        }
    }
}