using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private RemainingCandiesCounter _remainingCandiesCounter;
    [SerializeField] private Preferences _preferences;

    [SerializeField] private TextMeshProUGUI _timerText;
    [SerializeField] private TextMeshProUGUI _remainingCandiesText;

    public float TimeToGameOverUI { get; private set; }

    public bool IsTimerEnd { get; private set; }

    private void Awake()
    {
        TimeToGameOverUI = _preferences.TimeToGameOver;
    }

    private void Update()
    {
        if (TimeToGameOverUI > 0)
            TimeToGameOverUI -= Time.deltaTime;

        if (TimeToGameOverUI < 0)
            IsTimerEnd = true;

        _timerText.text = TimeToGameOverUI.ToString("00.00");
        _remainingCandiesText.text = _remainingCandiesCounter.CountOfRemainingCandies.ToString();
    }
}