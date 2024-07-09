using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressManager : MonoBehaviour
{
    [SerializeField] private int[] price;
    [SerializeField] private Image[] _progressBar;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        ChangeProgressBarState();
    }

    //оЋень двигатель прогресса

    private void ChangeProgressBarState()
    { 
        if (_gameManager.speedProgressLevel[0] >= 1)
        {
            _progressBar[0].color = Color.white;
            if (_gameManager.speedProgressLevel[0] == 2) { _progressBar[1].color = Color.white; } 
        }

        if (_gameManager.rotatableProgressLevel[0] >= 1) 
        { 
            _progressBar[2].color = Color.white; 
            if (_gameManager.rotatableProgressLevel[0] >= 2) 
            { 
                _progressBar[3].color = Color.white; 
                if (_gameManager.rotatableProgressLevel[0] >= 3) 
                { 
                    _progressBar[4].color = Color.white; 
                    if (_gameManager.rotatableProgressLevel[0] == 4) { _progressBar[5].color = Color.white; }
                }
            }
        }

        if (_gameManager.speedProgressLevel[1] >= 1)
        {
            _progressBar[6].color = Color.white;
            if (_gameManager.speedProgressLevel[1] == 2) { _progressBar[7].color = Color.white; }
        }

        if (_gameManager.rotatableProgressLevel[1] >= 1)
        {
            _progressBar[8].color = Color.white;
            if (_gameManager.rotatableProgressLevel[1] >= 2)
            {
                _progressBar[9].color = Color.white;
                if (_gameManager.rotatableProgressLevel[1] >= 3)
                {
                    _progressBar[10].color = Color.white;
                    if (_gameManager.rotatableProgressLevel[1] == 4) { _progressBar[11].color = Color.white; }
                }
            }
        }

        if (_gameManager.speedProgressLevel[2] >= 1)
        {
            _progressBar[12].color = Color.white;
            if (_gameManager.speedProgressLevel[2] == 2) { _progressBar[13].color = Color.white; }
        }

        if (_gameManager.rotatableProgressLevel[2] >= 1)
        {
            _progressBar[14].color = Color.white;
            if (_gameManager.rotatableProgressLevel[2] >= 2)
            {
                _progressBar[15].color = Color.white;
                if (_gameManager.rotatableProgressLevel[2] >= 3)
                {
                    _progressBar[16].color = Color.white;
                    if (_gameManager.rotatableProgressLevel[2] == 4) { _progressBar[17].color = Color.white; }
                }
            }
        }

        if (_gameManager.speedProgressLevel[3] >= 1)
        {
            _progressBar[18].color = Color.white;
            if (_gameManager.speedProgressLevel[3] == 2) { _progressBar[19].color = Color.white; }
        }

        if (_gameManager.rotatableProgressLevel[3] >= 1)
        {
            _progressBar[20].color = Color.white;
            if (_gameManager.rotatableProgressLevel[3] >= 2)
            {
                _progressBar[21].color = Color.white;
                if (_gameManager.rotatableProgressLevel[3] >= 3)
                {
                    _progressBar[22].color = Color.white;
                    if (_gameManager.rotatableProgressLevel[3] == 4) { _progressBar[23].color = Color.white; }
                }
            }
        }
    }
    public void SpeedProgress(string shipName)
    {
        if (_gameManager.speedProgressLevel[0] < 3 && shipName == "white" && _gameManager.playerMoney >= price[0])
        {
            _gameManager.playerMoney -= price[0];
            _gameManager.speedProgressLevel[0]++;
            _gameManager.speedMultiplier[0] = _gameManager.speedMultiplier[0] + 0.004f;
            ChangeProgressBarState();
            Debug.Log(_gameManager.playerMoney);
        }
        else if (_gameManager.speedProgressLevel[1] < 3 && shipName == "blue" && _gameManager.bluePlayerMoney >= price[0])
        {
            _gameManager.bluePlayerMoney -= price[0];
            _gameManager.speedProgressLevel[1]++;
            _gameManager.speedMultiplier[1] = _gameManager.speedMultiplier[1] + 0.004f;
            ChangeProgressBarState();
        }
        else if (_gameManager.speedProgressLevel[2] < 3 && shipName == "green" && _gameManager.greenPlayerMoney >= price[0])
        {
            _gameManager.greenPlayerMoney -= price[0];
            _gameManager.speedProgressLevel[2]++;
            _gameManager.speedMultiplier[2] = _gameManager.speedMultiplier[2] + 0.004f;
            ChangeProgressBarState();
        }
        else if (_gameManager.speedProgressLevel[3] < 3 && shipName == "yellow" && _gameManager.yellowPlayerMoney >= price[0])
        {
            _gameManager.yellowPlayerMoney -= price[0];
            _gameManager.speedProgressLevel[3]++;
            _gameManager.speedMultiplier[3] = _gameManager.speedMultiplier[3] + 0.004f;
            ChangeProgressBarState();
        }
    }
    public void RotateProgress(string shipName)
    {
        if (_gameManager.rotatableProgressLevel[0] < 5 && shipName == "white" && _gameManager.playerMoney >= price[1])
        {
            _gameManager.playerMoney -= price[1];
            _gameManager.rotatableProgressLevel[0]++;
            _gameManager.rotatableMultiplier[0] = _gameManager.rotatableMultiplier[0] + 3.5f;
            Debug.Log(_gameManager.playerMoney);
            ChangeProgressBarState();
        }
        else if (_gameManager.rotatableProgressLevel[1] < 5 && shipName == "blue" && _gameManager.bluePlayerMoney >= price[1])
        {
            _gameManager.bluePlayerMoney -= price[1];
            _gameManager.rotatableProgressLevel[1]++;
            _gameManager.rotatableMultiplier[1] = _gameManager.rotatableMultiplier[1] + 3.5f;
            ChangeProgressBarState();
        }
        else if (_gameManager.rotatableProgressLevel[2] < 5 && shipName == "green" && _gameManager.greenPlayerMoney >= price[1])
        {
            _gameManager.greenPlayerMoney -= price[1];
            _gameManager.rotatableProgressLevel[2]++;
            _gameManager.rotatableMultiplier[2] = _gameManager.rotatableMultiplier[2] + 3.5f;
            ChangeProgressBarState();
        }
        else if (_gameManager.rotatableProgressLevel[3] < 5 && shipName == "yellow" && _gameManager.yellowPlayerMoney >= price[1])
        {
            _gameManager.yellowPlayerMoney -= price[1];
            _gameManager.rotatableProgressLevel[3]++;
            _gameManager.rotatableMultiplier[3] = _gameManager.rotatableMultiplier[3] + 3.5f;
            ChangeProgressBarState();
        }
    }

}
