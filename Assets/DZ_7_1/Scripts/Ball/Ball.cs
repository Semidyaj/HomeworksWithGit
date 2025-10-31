using UnityEngine;

[SelectionBase]
public class Ball : MonoBehaviour
{
    [Header("Objects")]
    [SerializeField] private GroundChecker _groundChecker;
    [SerializeField] private CameraController _cameraController;

    [Header("Movement Settings")]
    [SerializeField] private float _speed;
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
        Vector3 moveDirection = _cameraController.GetCameraDirection();

        _rigidbody.AddForce(moveDirection * _speed);

        if (_isJump)
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _isJump = false;
        }
    }
}