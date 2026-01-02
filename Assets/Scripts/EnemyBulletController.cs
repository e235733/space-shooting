using UnityEngine;

public class EnemyBulletController : BulletController
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    protected override void Start()
    {
        base.Start();
        rb.linearVelocity = transform.up * bulletSpeed;
    }
}
