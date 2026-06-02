using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public int balance = 1000;   // starting money
    public int currentBet = 0;   // how much the player bet
    public int betNumber = -1;   // which number the player bet on

    public void PlaceBet(int number, int amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            currentBet = amount;
            betNumber = number;

            Debug.Log("Bet " + amount + " on number " + number);
        }
        else
        {
            Debug.Log("Not enough money!");
        }
    }

    public void WinBet()
    {
        int payout = currentBet * 35; // straight-up bet payout
        balance += payout;

        Debug.Log("WIN! +" + payout);
    }

    public void LoseBet()
    {
        Debug.Log("Lost bet.");
        int lose = currentBet;
        balance -= lose;
    }

    public void ResetBet()
    {
        currentBet = 0;
        betNumber = -1;
    }

}
