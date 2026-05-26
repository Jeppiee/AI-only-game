using UnityEngine;

public class WheelSpin : MonoBehaviour
{
    public float spinSpeed = 0f;
    public float deceleration = 0.2f;
    public bool spinning = false;

    void Update()
    {
        if (spinning)
        {
            spinSpeed -= deceleration * Time.deltaTime;
            if (spinSpeed < 0)
            {
                spinSpeed = 0;
                spinning = false;
            }

            transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
        }
    }

    public void StartSpin(float startSpeed)
    {
        spinSpeed = startSpeed;
        spinning = true;
    }
}
