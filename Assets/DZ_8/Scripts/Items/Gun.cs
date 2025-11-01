using UnityEngine;

namespace DZ_8
{
    public class Gun : Item
    {
        [SerializeField] private BulletSpawner _spawnedBullet;

        public override void Use()
        {
            _spawnedBullet.Spawn();

            Debug.Log("Вы сделали выстрел");
        }
    }
}