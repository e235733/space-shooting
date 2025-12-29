using System.Runtime.InteropServices;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float topMargin;
    private Rigidbody2D rb;
    private float topBound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 leftTopEdge = Camera.main.ViewportToWorldPoint(new Vector2(0, 1));
        topBound = leftTopEdge.y + topMargin;
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocityY = bulletSpeed;
        CheckOutOfBounce();
    }

    void CheckOutOfBounce()
    {
        if (rb.position.y > topBound)
        {
            Destroy(gameObject);
        }
    }
}
