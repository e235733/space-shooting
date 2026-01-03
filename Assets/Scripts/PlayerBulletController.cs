public class PlayerBulletController : BulletController
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        rb.linearVelocityY = bulletSpeed;
    }
}
