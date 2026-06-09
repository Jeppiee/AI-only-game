using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public int balance = 1000;   // starting money
    public int currentBet = 0;   // how much the player bet
    public int betNumber = -1;   // which number the player bet on
    public enum BetType { None, Number, Red, Black }
    public BetType betType = BetType.None;


    public void PlaceBet(int number, int amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            currentBet += amount;
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
        if (betType == BetType.Number)
        {
            // Straight-up number bet → 36x
            balance += currentBet * 36;
        }
        else if (betType == BetType.Red || betType == BetType.Black)
        {
            // Even-money bets → 2x
            balance += currentBet * 2;
        }
    }


    public void LoseBet()
    {
        Debug.Log("Lost bet.");
        
    }

    public void ResetBet()
    {       
        betType = BetType.None;
        betNumber = -1;
        currentBet = 0;
    }

}
