using System.Collections;
using UnityEngine;

public class KeyboardController : MonoBehaviour
{
    [SerializeField] private Player[] _players;
    [SerializeField] private GameObject _shadowUp;
    [SerializeField] private GameObject _shadowDown;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (_players[0] == null && _players[1] == null && _players[2] == null && _players[3] == null) { StartCoroutine(StopRound()); }
    }

    private IEnumerator StopRound()
    {
        yield return new WaitForSeconds(2f); //Работает не трогай

        _gameManager.LoadNextRound();
        
    }

    private void OnGUI()
    {
        if(_players[0] != null)
        {
            if (Input.GetKey(KeyCode.W)) _players[0].MoveForward();
            if (Input.GetKey(KeyCode.A)) _players[0].MoveLeft();
            if (Input.GetKey(KeyCode.S)) _players[0].MoveBack();
            if (Input.GetKey(KeyCode.D)) _players[0].MoveRight();
        }
        if (_players[1] != null)
        {
            if (Input.GetKey(KeyCode.RightArrow)) _players[1].MoveRight();
            if (Input.GetKey(KeyCode.LeftArrow)) _players[1].MoveLeft();
            if (Input.GetKey(KeyCode.UpArrow)) _players[1].MoveForward();
            if (Input.GetKey(KeyCode.DownArrow)) _players[1].MoveBack();
        }
        if (_players[2] != null)
        {
            if (Input.GetKey(KeyCode.L)) _players[2].MoveRight();
            if (Input.GetKey(KeyCode.J)) _players[2].MoveLeft();
            if (Input.GetKey(KeyCode.I)) _players[2].MoveForward();
            if (Input.GetKey(KeyCode.K)) _players[2].MoveBack();
        }
        if (_players[3] != null)
        {
            if (Input.GetKey(KeyCode.Keypad6)) _players[3].MoveRight();
            if (Input.GetKey(KeyCode.Keypad4)) _players[3].MoveLeft();
            if (Input.GetKey(KeyCode.Keypad8)) _players[3].MoveForward();
            if (Input.GetKey(KeyCode.Keypad5)) _players[3].MoveBack();
        }
    }
}
