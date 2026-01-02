using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField] private int maxHp;
    [SerializeField] private HPBarController hpBar;
    [SerializeField] private GameObject explosionEffectPrefab;
    [SerializeField] private GameManager gameManager;
    private int currentHp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        currentHp = maxHp;
    }

    public void ApplyDamage(int damageAmount)
    {
        if (gameManager.isGameFinished)
        {
            return;
        }
        currentHp -= damageAmount;
        if (hpBar != null)
        {
            hpBar.UpdateHPBar(currentHp, maxHp);
        }
        if (currentHp <= 0)
        {
            Instantiate(explosionEffectPrefab, transform.position, transform.rotation);

            if (gameObject.tag == "Player")
            {
                gameManager.PlayerLose();
            }
            else
            {
                gameManager.PlayerWin();
            }
            Destroy(gameObject);
        }
    }
}
