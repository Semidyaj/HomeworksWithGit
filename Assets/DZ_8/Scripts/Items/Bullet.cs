using UnityEngine;

namespace DZ_8
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float _bulletSpeed;

        private float _bulletTimeAlive;

        private bool _isSpawned;

        private void Start()
        {
            _isSpawned = true;
        }

        private void Update()
        {
            if (_isSpawned == false)
                return;

            _bulletTimeAlive += Time.deltaTime;

            if (_bulletTimeAlive < 5f)
                transform.position += Vector3.forward * _bulletSpeed * Time.deltaTime;
            else
                Destroy(gameObject);
        }
    }
}