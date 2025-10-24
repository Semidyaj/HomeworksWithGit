using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIManager _UIManager;

    private void Update()
    {
        if (_UIManager.IsTimerEnd)
            GameOver();
    }

    private void GameOver()
    {
        Debug.Log("Game Over");
    }
}