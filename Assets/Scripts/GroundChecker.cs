using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    //private const string BallTag = "Ball";
    private const string GroundTag = "Ground";

    public bool IsGround { get; private set; }

    private void OnCollisionStay(Collision collision)
    {
        if (collision != null && collision.gameObject.CompareTag(GroundTag))
            IsGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        IsGround = false;
    }
}