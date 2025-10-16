using TMPro;
using UnityEngine;

public class PlayerHealthSystem : MonoBehaviour
{

    // publiek zodat HealthPickup direct kan controleren (of gebruik methods)
    public int health = 50;
    public int maxHealth = 100;

    public Vector3 respawnPoint;

    public TextMeshProUGUI healthTextField;
    public TextMeshProUGUI feedbackTextField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("KillZone"))
        {
            LoseHealth();
        }
    }

    void LoseHealth()
    {
        health--;

        healthTextField.text = "x " + health;
        feedbackTextField.text = "Ouch! Health left: " + health;

        if (health < 0)
        {
            Debug.Log("Game Over");
        }
        else
        {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = respawnPoint;
    }

    public void AddHealth(int amount)
    {
        health = Mathf.Clamp(health + amount, 0, maxHealth);
    }

    // optionele helper
    public bool IsFull()
    {
        return health >= maxHealth;
    }

}
