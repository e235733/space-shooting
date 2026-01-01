using UnityEngine;

public class EnemyBulletController : BulletController
{
    [SerializeField] GameObject player;
    private Vector2 launchDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    protected override void Start()
    {
        base.Start();
        rb.linearVelocity = transform.up * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
