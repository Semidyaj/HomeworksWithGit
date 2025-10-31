using UnityEngine;

public class LookAtObject : MonoBehaviour
{
    [SerializeField] private Transform _ballTransform;

    private void LateUpdate()
    {
        transform.LookAt(_ballTransform.position);
    }
}