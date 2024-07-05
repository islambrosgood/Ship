using UnityEngine;

public class Wave : Enemy
{
    private void FixedUpdate()
    {
        Move();
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
