using UnityEngine;

public class PlayerVarHealth : MonoBehaviour
{
    [Header("Health Settings")]
    public int maxHealth = 100;
    public int currentHealth = 80;

    void Start()
    {
        Debug.Log("Current Health: " + currentHealth);
    }

    void Update()
    {
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }

    public void Heal(int amount)
    {
        if (amount <= 0) return;
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log("Player healed. Current health: " + currentHealth);
    }

    public bool IsFullHealth()
    {
        return currentHealth >= maxHealth;
    }
}