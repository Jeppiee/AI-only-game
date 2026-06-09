using UnityEngine;

public class RouletteManager : MonoBehaviour
{
    PlayerMoney player;
    RouletteUI ui;
    bool IsRed(int number)
    {
        int[] reds = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        return System.Array.IndexOf(reds, number) != -1;
    }
    bool IsBlack(int number)
    {
        return !IsRed(number) && number != 0;
    }

    void Start()
    {
        player = FindAnyObjectByType<PlayerMoney>();
        ui = FindAnyObjectByType<RouletteUI>();
    }

    public void OnPocketHit(int number)
    {
        Debug.Log("WINNING NUMBER = " + number);

        // Number bet
        if (player.betType == PlayerMoney.BetType.Number)
        {
            if (player.betNumber == number)
                player.WinBet();
            else
                player.LoseBet();
        }

        // Red bet
        else if (player.betType == PlayerMoney.BetType.Red)
        {
            if (IsRed(number))
                player.WinBet();
            else
                player.LoseBet();
        }

        // Black bet
        else if (player.betType == PlayerMoney.BetType.Black)
        {
            if (IsBlack(number))
                player.WinBet();
            else
                player.LoseBet();
        }

        player.ResetBet();
        FindAnyObjectByType<GameStart>().EndRound();
    }


}
