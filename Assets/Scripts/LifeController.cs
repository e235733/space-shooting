using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField] int maxHp;
    private int currentHp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        currentHp = maxHp;
    }

    public void ApplyDamage(int damageAmount)
    {
        currentHp -= damageAmount;
        if (currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
