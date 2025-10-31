using UnityEngine;

namespace DZ_8
{
    public class SpeedBottle : Item
    {
        [SerializeField] private int _additiveSpeed;

        private Player _player;

        private void Awake()
        {
            _player = FindObjectOfType<Player>();
        }

        public override void Use()
        {
            _player.AddSpeed(_additiveSpeed);

            Debug.Log("Вы использовали предмет \"Зелье скорости\"");
        }
    }
}