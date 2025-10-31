using UnityEngine;

namespace DZ_8
{
    public class SpeedBottle : Item
    {
        [SerializeField] private Player _player;

        [SerializeField] private int _additiveSpeed;

        public override void UseItem()
        {
            _player.AddSpeed(_additiveSpeed);

            Debug.Log("Вы использовали предмет \"Зелье скорости\"");
        }
    }
}