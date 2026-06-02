using UnityEngine;

public class RouletteManager : MonoBehaviour
{
    PlayerMoney player;
    RouletteUI ui;

    void Start()
    {
        player = FindAnyObjectByType<PlayerMoney>();
        ui = FindAnyObjectByType<RouletteUI>();
    }

    public void OnPocketHit(int number)
    {
        Debug.Log("WINNING NUMBER = " + number);

        ui.ShowWinningNumber(number);

        if (player.betNumber == number)
            player.WinBet();
        else
            player.LoseBet();

        player.ResetBet();
    }
}
