using UnityEngine;

public class PocketTrigger : MonoBehaviour
{
    public int pocketNumber;
    RouletteManager manager;

    float stayTime = 0f;
    bool ballInside = false;

    void Start()
    {
        manager = FindAnyObjectByType<RouletteManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ballInside = true;
            stayTime = 0f; // reset timer
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ballInside = false;
            stayTime = 0f; // reset timer
        }
    }

    void Update()
    {
        if (ballInside)
        {
            stayTime += Time.deltaTime;

            if (stayTime >= 3f) // 3 seconds inside
            {
                manager.OnPocketHit(pocketNumber);
                ballInside = false; // prevent multiple calls
            }
        }
    }
}
