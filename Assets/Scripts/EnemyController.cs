using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject enemyBullet;
    [SerializeField] private float interval;
    [SerializeField] private GameObject player;
    private Rigidbody2D rb;
    private float timeCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        if (timeCount > interval)
        {
            Transform target = player.transform;
            Vector2 direction = target.position - transform.position;
            GameObject bullet = Instantiate(enemyBullet, transform.position, transform.rotation);
            bullet.transform.up = direction;
            timeCount = 0;
        }
    }
}
