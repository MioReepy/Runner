using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerSpace
{
    public class InputController : MonoBehaviour
    {
        private PlayerInput _playerInput;
        private InputAction _moveAction;

        private void Awake()
        {
            _playerInput = GetComponent<PlayerInput>();
            _moveAction = _playerInput.actions["Move"];
        }

        private void Update()
        {
            Moving();
        }

        private void Moving()
        {
            Vector2 input = _moveAction.ReadValue<Vector2>();
            PlayerController.Instance.MoveInput = input;
        }
    }
}