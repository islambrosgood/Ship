using UnityEngine.UI;
using UnityEngine;
using System;

public class RoundAmountController : MonoBehaviour
{
    [SerializeField] private Slider _roundAmount;

    public void Update()
    {
        gameObject.GetComponent<Text>().text = "Количество раундов: " + _roundAmount.value;
    }

    public void SetRoundOnGameStart()
    {
        FindObjectOfType<GameManager>().SetRoundAmount(Convert.ToInt32(_roundAmount.value));
    }
}
