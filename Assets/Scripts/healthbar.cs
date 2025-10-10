using System;
using UnityEngine;

public class healthbar : MonoBehaviour
{
    private int Health = 54;

    void Start()
    {

        if (Health > 80)
        {
            Debug.Log("You're in perfect condition!");
        }
        else if (Health > 50 && Health < 80)
        {
            Debug.Log("You're doing fine, stay cautious!");
        }
        else if (Health > 20 && Health < 50)
        {
            Debug.Log("Warning: Health is getting low!");
        }
        else if (Health <= 20)
        {
            Debug.Log("Danger! You're close to dying!");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            Debug.Log("Current health:" + Health);
        }
       /* if (Input.GetKeyDown("t"))
        {
            int Health = 24;
            Health -= 10;
            Debug.Log("You took damage! Health is now at " + Health);
        }
        if (Input.GetKeyDown("h"))
        {
            int Health = 24;
            Health += 10;
            Debug.Log("You healed! Health is now at " + Health);
        }
        if (Input.GetKeyDown("r"))
        {
            int Health = 24;
            Debug.Log("Health is at " + Health);
        }
    */}
}