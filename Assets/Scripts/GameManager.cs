using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIManager _UIManager;
    [SerializeField] private RemainingCandiesCounter _remainingCandiesCounter;
    [SerializeField] private Ball _ball;
    [SerializeField] private Preferences _preferences;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            RestartGame();

        if (Time.timeScale == 0)
            return;

        if (_UIManager.IsTimerEnd)
            GameOver();

        if (_remainingCandiesCounter.Count == 0)
            GameWin();
    }

    private void RestartGame()
    {
        _remainingCandiesCounter.PrepareCandiesForNewGame();

        _ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        _ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        _UIManager.ResetTimeForRestart();

        _ball.transform.position = _preferences.StartPosition;
        _ball.transform.rotation = Quaternion.Euler(Vector3.zero);

        Time.timeScale = 1f;
    }

    private void GameWin()
    {
        Time.timeScale = 0f;
        Debug.Log("Congratulations! You won");
    }

    private void GameOver()
    {
        Time.timeScale = 0f;
        Debug.Log("Game Over");
    }
}