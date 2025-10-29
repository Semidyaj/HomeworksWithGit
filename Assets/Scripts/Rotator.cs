using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 50f;

    private int _firstSide = 1;
    private int _secondSide = -1;

    private int _currentSide;

    private void Awake()
    {
        _currentSide = DetermineRotateSide();
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * _currentSide * _rotateSpeed * Time.deltaTime);
    }

    private int DetermineRotateSide()
    {
        int chance = Random.Range(0, 2);

        return chance == 0 ? _firstSide : _secondSide;
    }
}