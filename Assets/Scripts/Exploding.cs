using UnityEngine;

public class Exploding : MonoBehaviour
{
    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= 31f) Destroy(gameObject);
    }
}
