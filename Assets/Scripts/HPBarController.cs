using UnityEngine;
using UnityEngine.UI;

public class HPBarController : MonoBehaviour
{
    [SerializeField] private Image fillImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void UpdateHPBar(float currentHP, float maxHP)
    {
        fillImage.fillAmount = currentHP / maxHP;
    }
}
