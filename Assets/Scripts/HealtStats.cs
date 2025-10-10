using UnityEngine;

public class HealtStats : MonoBehaviour
{
    int health = 100;

    void Start()
    {
        PrintHealthStatus();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            health = Mathf.Max(0, health - 20);
            PrintHealthStatus();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            health = Mathf.Min(100, health + 20);
            PrintHealthStatus();
        }
    }

    void PrintHealthStatus()
    {
        if (health >= 80)
        {
            Debug.Log("Health is excellent!");
        }
        else if (health >= 50)
        {
            Debug.Log("Health is good!");
        }
        else if (health >= 20)
        {
            Debug.Log("Health is low!");
        }
        else
        {
            Debug.Log("Warning: Very low health!");
        }
    }
}
