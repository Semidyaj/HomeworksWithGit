using UnityEngine;

public class Observer : MonoBehaviour
{
    [SerializeField] private Transform _ballTransform;

    private void LateUpdate()
    {
        transform.LookAt(_ballTransform.position);
    }
}