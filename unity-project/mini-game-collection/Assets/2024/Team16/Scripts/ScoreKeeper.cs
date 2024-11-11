using UnityEngine;


namespace MiniGameCollection.Games2024.Team16
{
    public class ScoreKeeper : MiniGameBehaviour
    {
        public MiniGameScoreUI scoreUI;

        private int player1Score = 0;
        private int player2Score = 0;

        void Start()
        {
            // Initialize scores
            scoreUI.SetPlayerScore(1, player1Score);
            scoreUI.SetPlayerScore(2, player2Score);
        }

        public void AddPoint(int playerID)
        {
            if (playerID == 1)
            {
                player1Score++;
                scoreUI.SetPlayerScore(1, player1Score);
            }
            else if (playerID == 2)
            {
                player2Score++;
                scoreUI.SetPlayerScore(2, player2Score);
            }
        }

        public int GetPlayerScore(int playerID)
        {
            if (playerID == 1)
            {
                return player1Score;
            }
            else if (playerID == 2)
            {
                return player2Score;
            }
            return 0;
        }
    }
}
