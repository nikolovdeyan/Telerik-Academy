namespace Minesweeper.Common
{
    public static class Constants
    {
        public static class TileSymbols
        {
            public const char Unchecked = '?';
            public const char Mine = '*';
            public const char Empty = '-';
        }

        public static class GameSettings
        {
            public const int PlayingFieldRows = 5;
            public const int PlayingFieldCols = 10;
            public const int PointsNeededToWin = 35;
            public const int StartingPoints = 0;
        }

        public static class Field
        {
            public const string PlayingFieldTopBorder =
    @"
    0 1 2 3 4 5 6 7 8 9
   ---------------------";

            public const string PlayingFieldBottomBorder =
    @"   ---------------------
";
        }

        public static class Messages
        {
            public const string Points = 
    @"
Score:";

            public const string Victory =
    @"
Congratulations! You opened all 35 cells with no drop of blood!";

            public const string Defeat =
@"
Daaayum! You stepped on a mine and died with a score of {0}.
Please provide your name : ";

            public const string ExitProgram =
    @"Exiting game...";

            public const string AskInput =
    @"Your turn: Provide row and column in format 'r c' ";

            public const string AskName =
    @"Daj si imeto, batka: ";

            public const string BadInputError =
    @"
Error! Invalid Command!
";

            public const string Welcome =
    @"        Let's play 'Minesweeper'!

Try your luck and find the fields with no mines.

Command 'top' will show the high scores,
        'restart' will start a new game,
        'exit' will exit the game

                Good Luck!";

            public const string Exit =
    @"Made in Bulgaria - Thanks for playing!
               Good bye!";
        }
    }
}
