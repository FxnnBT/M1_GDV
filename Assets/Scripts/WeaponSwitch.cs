using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    string currentWeapon = "Sword";
    void Start()
    {
        switch (currentWeapon)
        {
            case "Sword":
                Debug.Log("Switched to Sword");
                break;
            case "Bow":
                Debug.Log("Switched to Bow");
                break;
            case "Staff":
                Debug.Log("Switched to Staff");
                break;
            case "Dagger":
                Debug.Log("Switched to Dagger");
                break;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = "Sword";
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = "Bow";
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = "Staff";
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentWeapon = "Dagger";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
