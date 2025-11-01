using UnityEngine;

namespace DZ_8
{
    public class UsingItemsController : MonoBehaviour
    {
        [SerializeField] private Transform _parentObject;
        [SerializeField] private ParticleSystem _explosionEffect;

        private Item _item;

        private bool _isEmptyHands = true;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F) && _isEmptyHands == false)
                UseItem();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Item item) && _isEmptyHands)
            {
                BindToParent(item);
                _item = item;
            }

            _isEmptyHands = false;
        }

        private void BindToParent(Item childObject)
        {
            childObject.transform.SetParent(_parentObject);
            childObject.transform.position = _parentObject.position;
            childObject.transform.rotation = _parentObject.rotation;

            _isEmptyHands = false;
        }

        private void UseItem()
        {
            _item.Use();

            PlayExplosionEffect();
            Destroy(_item.gameObject);

            _isEmptyHands = true;
        }

        private void PlayExplosionEffect()
        {
            _explosionEffect.gameObject.SetActive(true);
            _explosionEffect.transform.position = _parentObject.position;
            _explosionEffect.Play();
        }
    }
}