using UnityEngine;

public class BallRoll : MonoBehaviour
{
    public float force = 50f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = 100f;
    }

    public void LaunchBall()
    {
        // Push the ball forward around the wheel
        rb.AddForce(transform.forward * force, ForceMode.Impulse);
    }
}
