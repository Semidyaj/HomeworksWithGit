using UnityEngine;

namespace DZ_8
{
    public class BecomeChildren : MonoBehaviour
    {
        [SerializeField] private Transform _parentObject;

        public void BecomeChild(Transform childObject)
        {
            childObject.SetParent(_parentObject);
            childObject.position = Vector3.zero;
            childObject.rotation = Quaternion.identity;
        }
    }
}