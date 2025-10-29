using System.Collections.Generic;
using UnityEngine;

public class RemainingCandiesCounter : MonoBehaviour
{
    [SerializeField] private List<Candy> _candies;
    private int _countOfRemainingCandies = 10;

    public int CountOfRemainingCandies => _countOfRemainingCandies;

    private void LateUpdate()
    {
        foreach (var candy in _candies)
        {
            if (candy.IsTaken)
            {
                _countOfRemainingCandies--;
                candy.DoIsTakenFalse();
                break;
            }
        }
    }

    public void PrepareCandiesForNewGame()
    {
        _countOfRemainingCandies = 10;

        foreach (var candy in _candies)
            candy.gameObject.SetActive(true);
    }
}