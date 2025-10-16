using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    [Header("Potion Settings")]
    public int healAmount = 25;

    private void OnTriggerEnter(Collider other)
    {
        PlayerVarHealth player = other.GetComponentInParent<PlayerVarHealth>();
        if (player == null) return;

        if (!player.IsFullHealth())
        {
            player.Heal(healAmount);
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Player already has full health.");
        }
    }
}