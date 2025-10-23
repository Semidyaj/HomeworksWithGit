using UnityEngine;

[SelectionBase]
public class Candy : MonoBehaviour
{
    [SerializeField] private ParticleSystem _disappearanceEffect;

    [SerializeField] private int _countOfRemainingCandies;

    public int CountOfRemainingCandies => _countOfRemainingCandies;

    private void OnTriggerEnter(Collider other)
    {
        _disappearanceEffect.transform.position = transform.position;

        gameObject.SetActive(false);

        _countOfRemainingCandies--;
        _disappearanceEffect.Play();
    }
}