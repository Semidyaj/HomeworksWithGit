using TMPro;
using UnityEngine;

namespace DZ_8
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _healthText;
        [SerializeField] private TextMeshProUGUI _speedText;

        [SerializeField] private Player _player;

        private void Update()
        {
            _healthText.text = _player.Health.ToString();
            _speedText.text = _player.Speed.ToString();
        }
    }
}