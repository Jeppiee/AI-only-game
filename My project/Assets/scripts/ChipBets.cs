using UnityEngine;

public class ChipBets : MonoBehaviour
{
    PlayerMoney player;
    public TMPro.TMP_InputField numberInput;
    public GameStart game;


    void Start()
    {
        player = FindAnyObjectByType<PlayerMoney>();
    }

    public void SelectNumber(int number)
    {
        player.betNumber = number;
        Debug.Log("Selected number: " + number);
    }

    public void BetAmount(int amount)
    {
        if (game.roundLocked) return;

        // Allow betting if ANY valid bet type is selected
        bool hasNumberBet = player.betType == PlayerMoney.BetType.Number && player.betNumber != -1;
        bool hasColorBet = player.betType == PlayerMoney.BetType.Red || player.betType == PlayerMoney.BetType.Black;

        if (hasNumberBet || hasColorBet)
        {
            player.PlaceBet(player.betNumber, amount);
        }
        else
        {
            Debug.Log("Select a number OR red/black first!");
        }
    }

    
    public void SelectNumberFromInput()
    {
        if (game.roundLocked) return;

        if (int.TryParse(numberInput.text, out int num))
        {
            if (num >= 0 && num <= 36)
            {
                player.betNumber = num;
                Debug.Log("Selected number: " + num);
            }
            else
            {
                Debug.Log("Number must be between 0 and 36");
            }
        }
        else
        {
            Debug.Log("Invalid number");
        }
    }

        public void SelectRed()
        {
        if (game.roundLocked) return;

        player.betType = PlayerMoney.BetType.Red;
        player.betNumber = -1; // no number bet
        Debug.Log("Bet on RED");
        }

    public void SelectBlack()
    {
        if (game.roundLocked) return;

        player.betType = PlayerMoney.BetType.Black;
        player.betNumber = -1;
        Debug.Log("Bet on BLACK");
    }

}


