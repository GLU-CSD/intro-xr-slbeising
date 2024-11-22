using UnityEngine;
using UnityEngine.UI; // Dit is nodig om Image te gebruiken

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public Image healthbarFill;

    // Start wordt nu binnen de Health klasse geplaatst
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    // UpdateHealthBar wordt ook binnen de Health klasse geplaatst
    void UpdateHealthBar()
    {
        healthbarFill.fillAmount = currentHealth / maxHealth;
    }

    // Methode om schade toe te voegen
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }

    // Methode om gezondheid te herstellen
    public void RestoreHealth(float amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }
}
