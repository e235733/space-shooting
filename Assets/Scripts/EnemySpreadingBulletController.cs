using UnityEngine;

public class EnemySpreadingBulletController : BulletController
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        rb.linearVelocity = transform.up * bulletSpeed;
    }
}
