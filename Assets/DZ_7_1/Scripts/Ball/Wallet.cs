using UnityEngine;

public class Wallet : MonoBehaviour
{
    public int Candies { get; private set; }

    public void AddCandy()
    {
        Candies++;
    }

    public void ResetCountForRestart() => Candies = 0;
}