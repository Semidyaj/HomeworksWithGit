using UnityEngine;

public class CameraController : MonoBehaviour
{
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";

    [SerializeField] private Transform _camera;

    public Vector3 GetCameraDirection()
    {
        float horizontal = Input.GetAxis(HorizontalAxis);
        float vertical = Input.GetAxis(VerticalAxis);

        Vector3 cameraForward = _camera.forward;
        cameraForward.y = 0f;
        cameraForward.Normalize();

        Vector3 cameraRight = _camera.right;
        cameraRight.y = 0f;
        cameraRight.Normalize();

        return (cameraForward * vertical + cameraRight * horizontal).normalized;
    }
}