using UnityEngine;

[SelectionBase]
public class Ball : MonoBehaviour
{
    [SerializeField] private GroundChecker _groundChecker;

    [SerializeField] private float _speed;
    [SerializeField] private float _force;
    [SerializeField] private float _jumpForce;

    private Rigidbody _rigitbody;

    private bool _isJump;

    private void Awake()
    {
        _rigitbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _isJump = true;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            _rigitbody.AddForce(Vector3.forward * _speed * _force, ForceMode.Force);

        if (Input.GetKey(KeyCode.S))
            _rigitbody.AddForce(Vector3.back * _speed * _force, ForceMode.Force);

        if (Input.GetKey(KeyCode.D))
            _rigitbody.AddForce(Vector3.right * _speed * _force, ForceMode.Force);

        if (Input.GetKey(KeyCode.A))
            _rigitbody.AddForce(Vector3.left * _speed * _force, ForceMode.Force);

        if (_isJump && _groundChecker.IsGround)
        {
            _rigitbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _isJump = false;
        }
    }
}