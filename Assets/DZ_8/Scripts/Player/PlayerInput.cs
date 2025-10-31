using UnityEngine;

namespace DZ_8
{
    public class PlayerInput : MonoBehaviour
    {
        private const string HorizontalAxis = "Horizontal";
        private const string VerticalAxis = "Vertical";

        [SerializeField] private Player _player;

        private void Update()
        {
            HandleMovement();
        }

        private void HandleMovement()
        {
            float horizontal = Input.GetAxis(HorizontalAxis);
            float vertical = Input.GetAxis(VerticalAxis);

            Vector3 direction = transform.right * horizontal + transform.forward * vertical;

            transform.position += direction * _player.Speed * Time.deltaTime;
        }
    }
}