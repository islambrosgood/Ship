using System.Collections;
using UnityEngine;

public class PirateShipScript : Enemy
{
    [SerializeField] private float _lifeTime;
    [SerializeField] private GameObject _crosshair;

    public GameObject[] _players;


    private void Start()
    {
        _players = GameObject.FindGameObjectsWithTag("Player");

        StartCoroutine(Shoot());
    }

    private void FixedUpdate()
    {
        _lifeTime -= Time.deltaTime;

        if (_lifeTime <= 0) Destroy(gameObject);

        Move();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }

    private IEnumerator Shoot()
    {
        int randomNum = Random.Range(0, _players.Length);

        if (_players[randomNum] != null)
            Instantiate(_crosshair, _players[randomNum].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(5f);
        StartCoroutine(Shoot());
    }
}
