using UnityEngine;

namespace DZ7_2
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private Vector3 _startPosition;

        private Rigidbody _rigidbody;

        public Vector3 StartPosition => _startPosition;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            _rigidbody.WakeUp();
        }

        public void SetDefaultState()
        {
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.angularVelocity = Vector3.zero;
            transform.position = _startPosition;
        }
    }
}