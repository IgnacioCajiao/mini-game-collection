using UnityEngine;


namespace MiniGameCollection.Games2024.Team16
{
    public class MyMiniGameManager : MiniGameBehaviour
    {
        private ScoreKeeper scoreKeeper;

        void Start()
        {
            scoreKeeper = FindObjectOfType<ScoreKeeper>();
        }

        protected override void OnGameStart()
        {
           
        }

        protected override void OnGameEnd()
        {
            DetermineWinner();
        }

        private void DetermineWinner()
        {
            // Logic to determine the winner
            int player1Score = scoreKeeper.GetPlayerScore(1);
            int player2Score = scoreKeeper.GetPlayerScore(2);

            if (player1Score > player2Score)
            {
                MiniGameManager.Winner = MiniGameWinner.Player1;
            }
            else if (player2Score > player1Score)
            {
                MiniGameManager.Winner = MiniGameWinner.Player2;
            }
            else
            {
                MiniGameManager.Winner = MiniGameWinner.Draw;
            }

            OnGameWinner(MiniGameManager.Winner);
        }
    }
}
