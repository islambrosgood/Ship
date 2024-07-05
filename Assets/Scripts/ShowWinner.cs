using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowWinner : MonoBehaviour
{
    [SerializeField] Image _ship;
    [SerializeField] Text _points;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();

        _gameManager.SetWinnerShip(_ship);
        _points.text = "Очки " + _gameManager.SetTheMostGotPointsShip();
    }
}
