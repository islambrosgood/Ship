using UnityEngine.UI;
using UnityEngine;

public class MoneyViewier : MonoBehaviour
{
    [SerializeField] private Player _moneyAmount;
    [SerializeField] private string _shipName;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    public void Update()
    {        if (_moneyAmount != null) { gameObject.GetComponent<Text>().text = "Монеты: " + _moneyAmount.money; }
        else
        {
            if (_shipName == "white") { gameObject.GetComponent<Text>().text = "Монеты: " + _gameManager.playerMoney; }
            else if (_shipName == "blue") { gameObject.GetComponent<Text>().text = "Монеты: " + _gameManager.bluePlayerMoney; }
            else if (_shipName == "green") { gameObject.GetComponent<Text>().text = "Монеты: " + _gameManager.greenPlayerMoney; }
            else if (_shipName == "yellow") { gameObject.GetComponent<Text>().text = "Монеты: " + _gameManager.yellowPlayerMoney; }
        }
    }
}
