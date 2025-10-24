using UnityEngine;

[SelectionBase]
public class Candy : MonoBehaviour
{
    [SerializeField] private ParticleSystem _disappearanceEffect;

    public bool IsTaken { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        _disappearanceEffect.transform.position = transform.position;

        gameObject.SetActive(false);

        IsTaken = true;
        _disappearanceEffect.Play();
    }

    public void DoIsTakenFalse() => IsTaken = false;
}