using UnityEngine;

namespace DZ7_2
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private HoleTrigger _holeTrigger;
        [SerializeField] private Ball _ball;
        [SerializeField] private GameObject _gameField;

        private void Update()
        {
            if ((Input.GetKeyDown(KeyCode.R)))
                RestartGame();

            if (_holeTrigger.IsFalled)
                GameWon();
        }

        private void RestartGame()
        {
            _gameField.transform.position = new Vector3(-6.5f, -1.5f, -3f);
            _gameField.transform.rotation = Quaternion.identity;

            _holeTrigger.SetIsFalledFalse();

            _ball.SetDefaultState();

            Time.timeScale = 1f;
        }

        private void GameWon()
        {
            Time.timeScale = 0f;
            Debug.Log("Congratulations");
        }
    }
}