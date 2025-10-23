using UnityEngine;

[SelectionBase]
public class Ball : MonoBehaviour
{
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";

    [Header("Objects")]
    [SerializeField] private GroundChecker _groundChecker;
    [SerializeField] private Transform _camera;

    [Header("Movement Settings")]
    [SerializeField] private float _speed;
    [SerializeField] private float _force;
    [SerializeField] private float _jumpForce;

    private Rigidbody _rigidbody;
    private bool _isJump;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _groundChecker.IsGround)
            _isJump = true;
    }

    private void FixedUpdate()
    {
        Vector3 moveDirection = GetCameraDirection();

        _rigidbody.AddForce(moveDirection * _speed * _force);

        if (_isJump)
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _isJump = false;
        }
    }

    private Vector3 GetCameraDirection()
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