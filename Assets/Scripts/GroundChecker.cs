using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    private const string BallTag = "Ball";

    public bool IsGround {  get; private set; }

    private void OnCollisionStay(Collision collision)
    {
        if(collision != null && collision.gameObject.CompareTag(BallTag))
            IsGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        IsGround = false;
    }
}