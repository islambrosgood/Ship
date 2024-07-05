using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _sailingSpeed;
    [SerializeField] private Sprite[] _shipStatus;
    [SerializeField] private Rigidbody2D _rigidBody;
    [SerializeField] private GameObject _shipPart;
    [SerializeField] private AudioClip _audio;
    [SerializeField] private string _shipName;

    private GameManager _gameManager;

    public int points;
    public int money;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        points = _gameManager.GetPointsAmount(_shipName);
        money = _gameManager.GetMoneyAmount(_shipName);
        _rotationSpeed += _gameManager.rotatableMultiplier[0];
        _sailingSpeed += _gameManager.speedMultiplier[0];
    }


    public void MoveRight()
    {
        transform.Rotate(0, 0, _rotationSpeed * -1 * Time.deltaTime);
    }

    public void MoveLeft()
    {
        transform.Rotate(0, 0, _rotationSpeed * Time.deltaTime);
    }

    public void MoveForward()
    {
        _rigidBody.AddForce(-transform.up * _sailingSpeed * Time.deltaTime);
    }

    public void MoveBack()
    {
        _rigidBody.AddForce(transform.up * _sailingSpeed * Time.deltaTime);
    }

    public void GetDamage()
    {
        _health--;
        GetComponent<SpriteRenderer>().sprite = _shipStatus[_health];
        GetComponent<AudioSource>().PlayOneShot(_audio);

        if (_health <= 0) Kill();
    }

    public void Kill()
    {
        _gameManager.SetPointsAmount(_shipName, points);
        _gameManager.SetMoneyAmount(_shipName, money);
        Instantiate(_shipPart, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MapBorderForPlayer")) Kill();

        if (collision.gameObject.CompareTag("Money"))
        {
            money += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Bone"))
        {
            points += 32;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Emerald"))
        {
            points += 64;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("MoneyChest"))
        {
            money += 5;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("MagicBall"))
        {
            points += 128;
            Destroy(collision.gameObject);
        }
    }
}
