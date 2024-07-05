using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetValuesInGameManager : MonoBehaviour
{
    private GameManager _gameManager;
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _gameManager.ResetValuesInMenu();
    }
}
