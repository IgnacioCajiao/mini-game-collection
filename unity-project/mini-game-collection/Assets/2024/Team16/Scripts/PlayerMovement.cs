using UnityEngine;

namespace MiniGameCollection.Games2024.Team16
{
    public class PlayerMovement : MiniGameBehaviour
    {
        [field: SerializeField, Range(1, 2)]
        private int PlayerID { get; set; } = 1;

        [field: SerializeField]
        private bool ControlsActive { get; set; }

        public float jumpForce = 5f;
        public float duckHeight = 0.5f;
        public float normalHeight = 2f;
        public float fallMultiplier = 2.5f;
        private bool isGrounded;
        private Rigidbody rb;
        private CapsuleCollider capsuleCollider;
        public int ID => PlayerID - 1;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            capsuleCollider = GetComponent<CapsuleCollider>();
        }

        protected override void OnGameStart()
        {
            ControlsActive = true;
        }

        protected override void OnGameEnd()
        {
            ControlsActive = false;
        }

        void Update()
        {
            if (!ControlsActive) return;

            var playerInput = ArcadeInput.Players[ID];

            // Handle jump
            if (playerInput.AxisY > 0 && isGrounded) 
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isGrounded = false;
            }

            // Handle duck
            if (playerInput.AxisY < 0) 
            {
                capsuleCollider.height = duckHeight;
            }
            else
            {
                capsuleCollider.height = normalHeight;
            }

            // Apply additional downward force when falling
            if (rb.velocity.y < 0)
            {
                rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
            }
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.GetComponent<GroundTag>())
            {
                isGrounded = true;
            }
        }
    }
}
