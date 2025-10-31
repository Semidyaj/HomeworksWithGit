using UnityEngine;

namespace DZ_8
{
    public class HPBottle : Item
    {
        [SerializeField] private Player _player;

        [SerializeField] private int _additiveHealth;

        public override void UseItem()
        {
            _player.AddHealthPoints(_additiveHealth);

            Debug.Log("Вы использовали предмет \"Зелье здоровья\"");
        }
    }
}