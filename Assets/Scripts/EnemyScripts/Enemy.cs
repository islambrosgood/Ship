using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] public float _speed;

    public void Move()
    {
        transform.Translate(0, _speed * -1 * Time.deltaTime, 0);
    }
}