using UnityEngine;

public class CrosshairSetDamage : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private float _lifeTime;
    [SerializeField] private GameObject _exploding;

    private void Update()
    {
        _lifeTime -= Time.deltaTime;

        if (_lifeTime <= 0)
            Destroy(gameObject);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_lifeTime <= 0.1 && collision.gameObject.CompareTag("Player"))
        {
            Instantiate(_exploding, collision.gameObject.transform.position, Quaternion.identity);
            collision.gameObject.GetComponent<Player>().Kill();
        }
    }
}
