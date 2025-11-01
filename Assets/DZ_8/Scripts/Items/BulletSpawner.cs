using UnityEngine;

namespace DZ_8
{
    public class BulletSpawner : MonoBehaviour
    {
        [SerializeField] private Bullet _bulletPrefab;

        public void Spawn() =>
            Instantiate(_bulletPrefab, transform.position, Quaternion.Euler(90f, 0, 0));
    }
}