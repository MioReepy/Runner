using UnityEngine;

namespace PlayerSpace
{
    public class PlayerController : MonoBehaviour
    {
        public static PlayerController Instance { get; private set; }

        internal bool isAlive = true;
        internal bool isGround;
        [SerializeField] private float _forwardSpeed;
        [SerializeField] private float _horizontalSpeed;
        [SerializeField] private float _jumpForce;
        [SerializeField] private LayerMask _groundMask;
        internal float horizontalInput;

        private Rigidbody _rb;

        private void Awake()
        {
            Instance = this;
            _rb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            if (isAlive)
            {
                Vector3 forwardMovement = Vector3.forward * (_forwardSpeed * Time.deltaTime);
                Vector3 horizontalMovement = Vector3.right * (_horizontalSpeed * horizontalInput * Time.deltaTime);
                _rb.MovePosition(_rb.position + forwardMovement + horizontalMovement);
            }
        }

        private void Update()
        {
            float playerHeight = GetComponent<Collider>().bounds.size.y;
            isGround = Physics.Raycast(transform.position, Vector3.down, (playerHeight / 2 + 0.1f), _groundMask);
        }

        internal void Jump()
        {
            _rb.AddForce(Vector3.up * _jumpForce);
        }
    }
}