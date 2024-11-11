using UnityEngine;

namespace MiniGameCollection.Games2024.Team16
{
    public class BulletSpawner : MiniGameBehaviour
    {
        [field: SerializeField, Range(1, 2)]
        private int PlayerID { get; set; } = 1;

        [field: SerializeField]
        private bool ControlsActive { get; set; }

        public GameObject bulletPrefab;
        public Transform spawnerP1;
        public Transform spawnerP2;
        public float bulletSpeed = 10f;
        public float shootCooldown = 3.0f;
        private float lastShootTime;
        public int ID => PlayerID - 1;

        void Start()
        {
            lastShootTime = -shootCooldown;
        }

        protected override void OnGameStart()
        {
            ControlsActive = true;
            Debug.Log("Game Started!");
        }

        protected override void OnGameEnd()
        {
            ControlsActive = false;
            Debug.Log("Game Ended!");
        }

        void Update()
        {
            if (!ControlsActive) return;

            var playerInput = ArcadeInput.Players[ID];

            if (Time.time - lastShootTime >= shootCooldown)
            {
                if (playerInput.Action1.Down)
                {
                    Debug.Log("Shoot Action1 detected");
                    ShootBullet(spawnerP1);
                    lastShootTime = Time.time;
                }

                if (playerInput.Action2.Down)
                {
                    Debug.Log("Shoot Action2 detected");
                    ShootBullet(spawnerP2);
                    lastShootTime = Time.time;
                }
            }
        }

        void ShootBullet(Transform spawner)
        {
            GameObject bullet = Instantiate(bulletPrefab, spawner.position, spawner.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.velocity = spawner.forward * bulletSpeed;
        }
    }
}
