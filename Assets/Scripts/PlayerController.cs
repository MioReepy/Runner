using UnityEngine;

namespace PlayerSpace
{
    public class PlayerController : MonoBehaviour
    {
        public static PlayerController Instance { get; private set; }
        private Vector3 _moveInput;

        public Vector2 MoveInput
        {
            set
            {
                _moveInput.x = value.x;
                _moveInput.y = 0f;
                _moveInput.z = value.y;
                Debug.Log($"{_moveInput.x}, {_moveInput.y}, {_moveInput.z}");
            }
        }

        private void Awake() => Instance = this;
        
        
    }
}
