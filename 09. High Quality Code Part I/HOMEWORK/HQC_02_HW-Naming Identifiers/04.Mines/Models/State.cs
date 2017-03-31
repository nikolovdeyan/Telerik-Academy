
using Minesweeper.Common;

namespace Minesweeper.Models
{
    internal struct State
    {
        internal char[,] displayField;
        internal char[,] playingField;
        internal int score;
        internal bool roundIsLost;
        internal bool firstMoveForRound;
        internal bool roundIsWon;

        public State(
            char[,] displayField,
            char[,] playingField,
            int score,
            bool roundIsLost,
            bool firstMoveForRound,
            bool roundIsWon)
        {
            this.displayField = displayField;
            this.playingField = playingField;
            this.score = score;
            this.roundIsLost = roundIsLost;
            this.firstMoveForRound = firstMoveForRound;
            this.roundIsWon = roundIsWon;
        }

        public static State Initial
        {
            get
            {
                return new State(
                                Field.GetNewDisplayField(),
                                Field.GetNewPlayingField(),
                                Constants.GameSettings.StartingPoints,
                                false,
                                true,
                                false);
            }
        }


    }
}
