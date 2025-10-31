using System.Collections.Generic;
using UnityEngine;

public class CandyCollector : MonoBehaviour
{
    [SerializeField] private Wallet _wallet;

    private List<Candy> _collectedCandies = new List<Candy>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Candy candy) == false)
            return;

        candy.Collect();
        _collectedCandies.Add(candy);

        _wallet.AddCandy();
    }

    public void PrepareCandiesForNewGame()
    {
        foreach (var candy in _collectedCandies)
            candy.SetCollectedCandiesActive();
    }
}