using UnityEngine;

namespace DZ7_2
{
    public class FieldRotator : MonoBehaviour
    {
        private const string AxisX = "Mouse X";
        private const string AxisZ = "Mouse Y";

        [SerializeField] private float _sensitivity;

        private void Update()
        {
            if (Input.GetMouseButton(0) == false)
                return;

            float aroundXRotation = Input.GetAxis(AxisX) * _sensitivity;
            float aroundZRotation = Input.GetAxis(AxisZ) * _sensitivity;

            transform.Rotate(Vector3.right, aroundZRotation, Space.World);
            transform.Rotate(Vector3.forward, -aroundXRotation, Space.World);
        }
    }
}