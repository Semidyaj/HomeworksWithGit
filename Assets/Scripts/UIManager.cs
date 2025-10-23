using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Candy _candy;

    [SerializeField] private TextMeshProUGUI _timerText;
    [SerializeField] private TextMeshProUGUI _remainingCandiesText;
    [SerializeField] private float _timerToGameOver;

    public bool IsTimerEnd { get; private set; }

    private void Update()
    {
        if (_timerToGameOver > 0)
            _timerToGameOver -= Time.deltaTime;

        _timerText.text = _timerToGameOver.ToString("00.00");
        _remainingCandiesText.text = _candy.CountOfRemainingCandies.ToString();

        CheckGameOver();
    }

    private void CheckGameOver()
    {
        if (_timerToGameOver == 0)
            IsTimerEnd = true;
    }
}