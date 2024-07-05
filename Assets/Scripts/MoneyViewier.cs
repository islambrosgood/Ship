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
    {        if (_moneyAmount != null) { gameObject.GetComponent<Text>().text = "������: " + _moneyAmount.money; }
        else
        {
            if (_shipName == "white") { gameObject.GetComponent<Text>().text = "������: " + _gameManager.playerMoney; }
            else if (_shipName == "blue") { gameObject.GetComponent<Text>().text = "������: " + _gameManager.bluePlayerMoney; }
            else if (_shipName == "green") { gameObject.GetComponent<Text>().text = "������: " + _gameManager.greenPlayerMoney; }
            else if (_shipName == "yellow") { gameObject.GetComponent<Text>().text = "������: " + _gameManager.yellowPlayerMoney; }
        }
    }
}
