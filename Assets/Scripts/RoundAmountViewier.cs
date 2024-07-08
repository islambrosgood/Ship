using UnityEngine;
using UnityEngine.UI;

public class RoundAmountViewier : MonoBehaviour
{
    [SerializeField] private float _timer;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        gameObject.GetComponent<Text>().text = "Осталось раундов: " + _gameManager.roundAmount;
    }

    private void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer <= 0.01)
            Destroy(gameObject);
    }
}
