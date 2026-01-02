using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField] private int maxHp;
    [SerializeField] private HPBarController hpBar;
    private int currentHp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        currentHp = maxHp;
    }

    public void ApplyDamage(int damageAmount)
    {
        currentHp -= damageAmount;
        if (hpBar != null)
        {
            hpBar.UpdateHPBar(currentHp, maxHp);
        }
        if (currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
