using System.Runtime.InteropServices;
using UnityEngine;

public class DestroyShadow : MonoBehaviour
{

    [SerializeField] private float _timer;

    private void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0.01)
            Destroy(gameObject);
    }
}
