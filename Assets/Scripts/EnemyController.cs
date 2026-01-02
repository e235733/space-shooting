using UnityEditor.Callbacks;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject trackingBulletPrefab;
    [SerializeField] private GameObject spreadingBulletPrefab;
    [SerializeField] private float trackingBulletInterval;
    [SerializeField] private float spreadingBulletInterval;
    [SerializeField] private float angleStep;
    [SerializeField] private GameObject player;
    private float trackingBulletTimeCount = 0;
    private float spreadingBulletTimeCount = 0;
    private float currentAngle = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        trackingBulletTimeCount += Time.deltaTime;
        spreadingBulletTimeCount += Time.deltaTime;
        if (trackingBulletTimeCount >= trackingBulletInterval)
        {
            if (player != null)
            {
                Transform target = player.transform;
                Vector2 direction = target.position - transform.position;
                GameObject trackingBullet = Instantiate(trackingBulletPrefab, transform.position, transform.rotation);
                trackingBullet.transform.up = direction;
            }
            trackingBulletTimeCount = 0;
        }
        if (spreadingBulletTimeCount >= spreadingBulletInterval)
        {
            currentAngle += angleStep;
            currentAngle %= 360f;
            Quaternion rotation = Quaternion.Euler(0, 0, currentAngle);
            Instantiate(spreadingBulletPrefab, transform.position, rotation);
            spreadingBulletTimeCount = 0;
        }
    }
}