using UnityEngine;

[SelectionBase]
public class Candy : MonoBehaviour
{
    [SerializeField] private ParticleSystem _disappearanceEffect;
    [SerializeField] private ParticleSystem _rotateEffect;

    public void Collect()
    {
        _disappearanceEffect.transform.position = transform.position;

        gameObject.SetActive(false);

        _disappearanceEffect.Play();
        _rotateEffect.Stop();
    }

    public void SetCollectedCandiesActive() => gameObject.SetActive(true);
}