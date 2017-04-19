namespace Minesweeper.Models
{
    public class Score
    {
        private string playerName;
        private int playerScore;

        internal Score()
        {
        }

        internal Score(string name, int score)
        {
            this.PlayerName = name;
            this.PlayerScore = score;
        }

        internal string PlayerName
        {
            get
            {
                return this.playerName;
            }

            set
            {
                this.playerName = value;
            }
        }

        internal int PlayerScore
        {
            get
            {
                return this.playerScore;
            }

            set
            {
                this.playerScore = value;
            }
        }
    }
}