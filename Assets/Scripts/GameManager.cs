using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Sprite[] _shipSprites;
    private bool _isOriginalManager;

    public int playerPoints;
    public int playerMoney;
    public int bluePlayerPoints;
    public int bluePlayerMoney;
    public int greenPlayerPoints;
    public int greenPlayerMoney;
    public int yellowPlayerPoints;
    public int yellowPlayerMoney;

    public float[] speedMultiplier;
    public float[] rotatableMultiplier;
    public int[] speedProgressLevel;
    public int[] rotatableProgressLevel;

    public int roundAmount;
    public int progressSceneIndex;
  
    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        GameManager[] check = FindObjectsOfType<GameManager>();

        if (check.Length == 1) { _isOriginalManager = true; }
        else if (_isOriginalManager == false) { Destroy(gameObject); }
    }

    public void SetRoundAmount(int num)
    {
        roundAmount = num;
    }

    public int GetMoneyAmount(string shipName)
    {
        switch (shipName)
        {
            case "white":
                return playerMoney;
            case "blue":
                return bluePlayerMoney;
            case "green":
                return greenPlayerMoney;
            case "yellow":
                return yellowPlayerMoney;
            default:
                return 0;
        }
    }

    public int GetPointsAmount(string shipName)
    {
        switch (shipName)
        {
            case "white":
                return playerPoints;
            case "blue":
                return bluePlayerPoints;
            case "green":
                return greenPlayerPoints;
            case "yellow":
                return yellowPlayerPoints;
            default:
                return 0;
        }
    }

    public void SetMoneyAmount(string shipName, int amount)
    {
        switch (shipName)
        {
            case "white":
                playerMoney = amount;
                break;
            case "blue":
                bluePlayerMoney = amount;
                break;
            case "green":
                greenPlayerMoney = amount;
                break;
            case "yellow":
                yellowPlayerMoney = amount;
                break;

        }
    }

    public void SetPointsAmount(string shipName, int amount)
    {
        switch (shipName)
        {
            case "white":
                playerPoints = amount;
                break;
            case "blue":
                bluePlayerPoints = amount;
                break;
            case "green":
                greenPlayerPoints = amount;
                break;
            case "yellow":
                yellowPlayerPoints = amount;
                break;

        }
    }

    public void ResetValuesInMenu()
    {
        playerPoints = 0;
        playerMoney = 0;

        bluePlayerMoney = 0;
        bluePlayerPoints = 0;

        greenPlayerPoints = 0;
        greenPlayerMoney = 0;

        yellowPlayerPoints = 0;
        yellowPlayerMoney = 0;

        roundAmount = 0;
        progressSceneIndex = 0;


        for (int i = 0; i < 4; i++)
        {
            speedMultiplier[i] = 0;
            rotatableMultiplier[i] = 0;
            speedProgressLevel[i] = 0;
            rotatableProgressLevel[i] = 0;
        }
    }

    public void SetProgressSceneIndex(int index)
    {
        progressSceneIndex = index;
    }

    public void LoadNextRound()
    {
        roundAmount--;
        if (roundAmount <= 0)
        {
            if (progressSceneIndex == 5) { SceneManager.LoadScene(9); }
            else { SceneManager.LoadScene(10); }
        }
        else { SceneManager.LoadScene(progressSceneIndex); }
    }

    public float GetSpeedMultiplier(string shipName)
    {
        if (shipName == "white") { return speedMultiplier[0]; }
        else if (shipName == "blue") { return speedMultiplier[1]; }
        else if (shipName == "green") { return speedMultiplier[2]; }
        else if (shipName == "yellow") { return speedMultiplier[3]; }
        else { return 0; }
    }

    // Не смотреть. Опасно для жизни.

    public void SetWinnerShip(Image img)
    {
        if(playerPoints > bluePlayerPoints && playerPoints > greenPlayerPoints && playerPoints > yellowPlayerPoints) { img.sprite = _shipSprites[0]; }
        else if (bluePlayerPoints > greenPlayerPoints && bluePlayerPoints > yellowPlayerPoints) { img.sprite = _shipSprites[1]; }
        else if (greenPlayerPoints > yellowPlayerPoints ) { img.sprite = _shipSprites[2]; }
        else { img.sprite = _shipSprites[3]; }
    }

    public int SetTheMostGotPointsShip()
    {
        if (playerPoints > bluePlayerPoints && playerPoints > greenPlayerPoints && playerPoints > yellowPlayerPoints) { return playerPoints; }
        else if (bluePlayerPoints > greenPlayerPoints && bluePlayerPoints > yellowPlayerPoints) { return bluePlayerPoints; }
        else if (greenPlayerPoints > yellowPlayerPoints) { return greenPlayerPoints; }
        else { return yellowPlayerPoints; }
    }
}
