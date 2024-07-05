using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetProgressSceneController : MonoBehaviour
{
    private GameManager _gameManager;
    private int _index;

    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    public void GetIndex(int index)
    {
        _index = index;
        _gameManager.SetProgressSceneIndex(_index);
    }
}
