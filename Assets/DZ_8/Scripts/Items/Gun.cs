using UnityEngine;

namespace DZ_8
{
    public class Gun : Item
    {
        [SerializeField] private float _bulletSpeed;
        [SerializeField] private float _bulletTimeAlive;
        [SerializeField] private Bullet _bullet;

        private void Awake()
        {
            _bullet = GetComponent<Bullet>();
        }

        public override void Use()
        {
            _bulletTimeAlive += Time.deltaTime;

            while (_bulletTimeAlive < 5f)
                _bullet.transform.position += transform.forward * _bulletSpeed * Time.deltaTime;
        }
    }
}