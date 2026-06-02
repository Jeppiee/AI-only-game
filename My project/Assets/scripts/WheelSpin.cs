using UnityEngine;

public class WheelSpin : MonoBehaviour
{
    public float spinSpeed = 0f;
    public float deceleration = 0f;
    public bool spinning = false;

    void Update()
    {
        if (spinning)
        {
            spinSpeed -= deceleration * Time.deltaTime;

            if (spinSpeed <= 0)
            {
                spinSpeed = 0;
                spinning = false;
            }

            transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
        }

        // PRESS SPACE TO SPIN
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartSpin();
        }
    }

    public void StartSpin()
    {
        // RANDOM START SPEED
        spinSpeed = Random.Range(200f, 500f);

        // RANDOM DECELERATION
        deceleration = Random.Range(20f, 50f);

        spinning = true;
    }
}
