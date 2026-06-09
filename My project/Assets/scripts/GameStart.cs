using UnityEngine;
using System.Collections;


public class GameStart : MonoBehaviour
{
    public WheelSpin wheel;
    public BallRoll ball;
    public bool roundLocked = false;


    public void StartRound()
    {
        roundLocked = true;
        wheel.SpinButton();
        ball.DropBall();
    }

    public void EndRound()
    {
        StartCoroutine(ResetAfterDelay());
    }

    IEnumerator ResetAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        ball.ResetBall();
        roundLocked = false;

    }
}
