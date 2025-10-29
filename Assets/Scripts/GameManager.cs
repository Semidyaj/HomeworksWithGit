using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIManager _UIManager;
    [SerializeField] private RemainingCandiesCounter _remainingCandiesCounter;
    [SerializeField] private Ball _ball;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            RestartGame();

        if (Time.timeScale == 0)
            return;

        if (_UIManager.IsTimerEnd)
            GameOver();

        if (_remainingCandiesCounter.CountOfRemainingCandies == 0)
            GameWin();
    }

    private void RestartGame()
    {
        _remainingCandiesCounter.PrepareCandiesForNewGame();
        _ball.transform.position = _ball.StartPosition;
        _ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        _ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        _UIManager.ResetTimeForRestart();
        Time.timeScale = 1f;
    }

    private void GameWin()
    {
        StartCoroutine(DelayForWin());
        Debug.Log("Congratulations! You won");
    }

    private void GameOver()
    {
        Time.timeScale = 0f;
        Debug.Log("Game Over");
    }

    private IEnumerator DelayForWin()
    {
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 0f;
    }
}