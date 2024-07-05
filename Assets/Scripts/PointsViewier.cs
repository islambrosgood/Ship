using UnityEngine.UI;
using UnityEngine;

public class PointsViewier : MonoBehaviour
{
    [SerializeField] private Player _pointsAmount;
    [SerializeField] private string _shipName;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    public void Update()
    {
        if(_pointsAmount != null) { gameObject.GetComponent<Text>().text = "西觇: " + _pointsAmount.points; }
        else 
        {
            if (_shipName == "white") { gameObject.GetComponent<Text>().text = "西觇: " + _gameManager.playerPoints; }
            else if (_shipName == "blue") { gameObject.GetComponent<Text>().text = "西觇: " + _gameManager.bluePlayerPoints; }
            else if (_shipName == "green") { gameObject.GetComponent<Text>().text = "西觇: " + _gameManager.greenPlayerPoints; }
            else if (_shipName == "yellow") { gameObject.GetComponent<Text>().text = "西觇: " + _gameManager.yellowPlayerPoints; }
        }
    }
}
