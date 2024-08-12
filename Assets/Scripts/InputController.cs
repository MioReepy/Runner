using UnityEngine;

namespace PlayerSpace
{
    public class InputController : MonoBehaviour
    {
        private void Update()
        {
            PlayerController.Instance.horizontalInput = Input.GetAxis("Horizontal");

            if (Input.GetKeyDown(KeyCode.Space) && PlayerController.Instance.isAlive && PlayerController.Instance.isGround)
            {
                PlayerController.Instance.Jump();
            }
        }
    }
}
