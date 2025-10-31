using UnityEngine;

public class Preferences : MonoBehaviour
{
    [SerializeField] private float _timeToGameOver;
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private int _countOfCandiesToWin;
    public float TimeToGameOver => _timeToGameOver;
    public Vector3 StartPosition => _startPosition;
    public int CountOfCandiesToWin => _countOfCandiesToWin;
}