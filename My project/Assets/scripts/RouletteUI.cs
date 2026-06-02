using UnityEngine;
using TMPro;

public class RouletteUI : MonoBehaviour
{
    public TextMeshProUGUI balanceText;
    public TextMeshProUGUI betText;
    public TextMeshProUGUI betNumberText;
    public TextMeshProUGUI winningNumberText;

    PlayerMoney player;

    void Start()
    {
        player = FindAnyObjectByType<PlayerMoney>();
    }

    void Update()
    {
        balanceText.text = "Balance: " + player.balance;
        betText.text = "Bet: " + player.currentBet;
        betNumberText.text = "Bet Number: " + player.betNumber;
    }

    public void ShowWinningNumber(int number)
    {
        winningNumberText.text = "WINNING NUMBER: " + number;
    }
}
