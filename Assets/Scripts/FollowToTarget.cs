using UnityEngine;

public class FollowToTarget : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _sensitivity = 200f;

    private float _rotationAngleY;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _sensitivity * Time.deltaTime;
        _rotationAngleY += mouseX;

        Quaternion rotation = Quaternion.Euler(0f, _rotationAngleY, 0f);
        Vector3 desiredPosition = _target.position + rotation * _offset;

        transform.position = desiredPosition;
        transform.LookAt(_target);
    }
}