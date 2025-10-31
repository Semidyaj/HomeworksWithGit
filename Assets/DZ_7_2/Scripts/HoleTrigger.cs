using UnityEngine;

namespace DZ7_2
{
    public class HoleTrigger : MonoBehaviour
    {
        public bool IsFalled { get; private set; }

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Ball>())
            {
                IsFalled = true;
            }
        }

        public void SetIsFalledFalse() => IsFalled = false;
    }
}