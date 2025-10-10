using UnityEngine;

public class WeaponSwitchV2 : MonoBehaviour
{
    public enum WeaponType { Sword, Bow, Axe, Shield }

    public WeaponType selectedWeapon = WeaponType.Sword;

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            selectedWeapon = WeaponType.Sword;
            Debug.Log("You have a " + selectedWeapon);
        }

        if (Input.GetKeyDown("2"))
        {
            selectedWeapon = WeaponType.Bow;
            Debug.Log("You have a " + selectedWeapon);
        }

        if (Input.GetKeyDown("3"))
        {
            selectedWeapon = WeaponType.Axe;
            Debug.Log("You have a " + selectedWeapon);
        }

        if (Input.GetKeyDown("4"))
        {
            selectedWeapon = WeaponType.Shield;
            Debug.Log("You have a " + selectedWeapon);
        }
    }
}