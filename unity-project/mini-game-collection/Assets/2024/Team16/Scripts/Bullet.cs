using UnityEngine;

namespace MiniGameCollection.Games2024.Team16
{
    public class Bullet : MonoBehaviour
    {
        public int playerID; // The player who shot the bullet
        private ScoreKeeper scoreKeeper;

        void Start()
        {
            scoreKeeper = FindObjectOfType<ScoreKeeper>();
        }

        void OnCollisionEnter(Collision collision)
        {
            // Check if the bullet collides with a player using PlayerTag
            if (collision.gameObject.GetComponent<PlayerTag>())
            {
                // Add point to the player who shot the bullet
                scoreKeeper.AddPoint(playerID);

                Destroy(gameObject);
            }
        }
    }
}
