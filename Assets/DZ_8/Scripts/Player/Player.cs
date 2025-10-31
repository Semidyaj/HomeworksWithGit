using UnityEngine;

namespace DZ_8
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private float _speed;

        public int Health => _health;
        public float Speed => _speed;

        public void AddHealthPoints(int additiveHealth)
        {
            if (additiveHealth >= 0)
                _health += additiveHealth;
        }

        public void AddSpeed(float additiveSpeed)
        {
            if (additiveSpeed >= 0)
                _speed += additiveSpeed;
        }
    }
}