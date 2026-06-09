using UnityEngine;

public class BallRoll : MonoBehaviour
{
    Rigidbody rb;
    Vector3 startPos;
    Quaternion startRot;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        startPos = transform.position;
        startRot = transform.rotation;

        FreezeBall();
    }

    public void FreezeBall()
    {
        rb.isKinematic = true;
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

    public void DropBall()
    {
        rb.isKinematic = false;
    }

    public void ResetBall()
    {
        transform.position = startPos;
        transform.rotation = startRot;

        FreezeBall();
    }
}
