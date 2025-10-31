using UnityEngine;

namespace DZ_8
{
    public class HPBottle : Item
    {
        [SerializeField] private int _additiveHealth;

        private Player _player;

        private void Awake()
        {
            _player = FindObjectOfType<Player>();
        }

        public override void Use()
        {
            _player.AddHealthPoints(_additiveHealth);

            Debug.Log("Вы использовали предмет \"Зелье здоровья\"");
        }
    }
}