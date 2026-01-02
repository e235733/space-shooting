using UnityEngine;

public abstract class BulletController : MonoBehaviour
{
    [SerializeField] protected float bulletSpeed;
    [SerializeField] protected float Margin;
    [SerializeField] protected string targetTag;
    [SerializeField] protected int power;
    protected Rigidbody2D rb;
    private float topBound, bottomBound, rightBound, leftBound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 leftTopEdge = Camera.main.ViewportToWorldPoint(new Vector2(0, 1));
        Vector2 rightBottomEdge = Camera.main.ViewportToWorldPoint(new Vector2(1, 0));
        topBound = leftTopEdge.y + Margin;
        bottomBound = rightBottomEdge.y - Margin;
        rightBound = rightBottomEdge.x + Margin;
        leftBound = leftTopEdge.x - Margin;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        CheckOutOfBounce();
    }

    private void CheckOutOfBounce()
    {
        if (rb.position.y > topBound || rb.position.y < bottomBound || rb.position.x > rightBound || rb.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(targetTag))
        {
            LifeController targetLife = collision.GetComponentInParent<LifeController>();
            targetLife.ApplyDamage(power);
            Destroy(gameObject);
        }
    }
}
