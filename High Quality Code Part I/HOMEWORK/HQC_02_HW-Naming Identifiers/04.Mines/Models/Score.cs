namespace Minesweeper.Models
{
    public class Score
    {
        private string playerName;
        private int playerScore;

        public Score()
        {
        }

        public Score(string name, int score)
        {
            this.PlayerName = name;
            this.PlayerScore = score;
        }

        public string PlayerName
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

        public int PlayerScore
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