using UnityEngine;

public class SharkScript : Enemy
{
    private float _goingTime;
    private GameObject[] _players;
    private Vector3 _direction;
    private float _angle;
    private int _randomNumber;

    private void Start()
    {
        _players = GameObject.FindGameObjectsWithTag("Player");
        _randomNumber = Random.Range(0, _players.Length);
        _goingTime = Random.Range(10f, 20f);
    }

    private void FixedUpdate()
    {
        _goingTime -= Time.deltaTime;

        Move();

        if(_goingTime > 0)
        {
           RotateToPlayer();
        }
    }

    private void RotateToPlayer()
    {
        if(_players[_randomNumber] != null)
        {
            _direction = _players[_randomNumber].transform.position - transform.position;
            _angle = Mathf.Atan2(_direction.y, _direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, _angle + 90f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player>().GetDamage();
            Destroy(gameObject);
        }
    }
}