using UnityEngine;

public class Statscript : MonoBehaviour
{
//Tip: Met een header kun je titels plaatsen in de inspector
    [Header("Character Info")]
    public string playerName = "Jack Cooper";
    public int level = 103;
    public string characterClass = "Pilot";
    public string race = "Human";
    public bool isAlive = true;
    //add your own stats here

    [Header("Combat Stats")]
    public int health = 100;
    public int maxHealth = 100;
    public int mana = 50;
    public int attack = 50;
    public int defense = 70;
    public float speed = 5.5f;
    public int criticalChance = 10; //in percentage
    //add your own stats here

    [Header("Game Progress")]
    public int experience = 0;
    public int gold = 150;
    public float playtimeHours = 2.5f;
    public bool hasCompletedTutorial = true;
    public bool hasFoundSecretItem = false;
    public int questsCompleted = 5;
    //add your own stats here

    [Header("Inventory")]
    public int healthPotions = 1;
    public int keys = 1;
    public string currentWeapon = "R-201 Assault Rifle";
    public int jumpkitstatus = 3;
    public int currentAmmo = 130;
    //add your own stats here

    void Start()
    {
        DisplayCharacterSheet();
    }

    void Update()
    {
        // Input om stats te updaten
        if (Input.GetKeyDown(KeyCode.L))
        {
            //Level UP!
            level++;
            maxHealth += 20;
            health = maxHealth; // Full heal bij level up
            attack += 5;
            defense += 3;
            mana += 10;

            Debug.Log("LEVEL UP! Now level " + level);
            Debug.Log("Stats increased!");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            //Use Health Potion
            if (healthPotions > 0 && health < maxHealth)
            {
                healthPotions--;
                health += 30;
                if (health > maxHealth) health = maxHealth;

                Debug.Log("Used health potion! Health: " + health + "/" + maxHealth);
                Debug.Log("Potions remaining: " + healthPotions);
            }
            else if (healthPotions <= 0)
            {
                Debug.Log("No health potions left!");
            }
            else
            {
                Debug.Log("Health is already full!");
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            DisplayCharacterSheet();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            int damageAmount = 15;
            health -= damageAmount;
            Debug.Log("Took " + damageAmount + " damage! Health: " + health + "/" + maxHealth);
        }
        if (Input.GetKeyDown(KeyCode.K))
            {
                int regenAmount = 10;
                health += regenAmount;
                Debug.Log("Used health regen! Health: " + health + "/" + maxHealth);
            }
        //Reset Stats here when R is pressed!

    }

    private void DisplayCharacterSheet(){
        //Display Character Sheet
        Debug.Log("=== CHARACTER SHEET ===");
        Debug.Log("Name: " + playerName + " the " + characterClass);
        Debug.Log("Race: " + race);
        Debug.Log("Status: " + (isAlive ? "Alive" : "Deceased"));
        Debug.Log("Level: " + level);
        Debug.Log("Health: " + health + "/" + maxHealth);
        Debug.Log("Speed: " + speed + " | Critical Chance: " + criticalChance + "%");
        Debug.Log("Mana: " + mana);
        Debug.Log("Attack: " + attack + " | Defense: " + defense);
        Debug.Log("Jumpkitstatus: " + jumpkitstatus);
        Debug.Log("Current Ammo: " + currentAmmo);
        Debug.Log("Experience: " + experience + " XP");
        Debug.Log("Gold: " + gold + " coins");
        Debug.Log("Playtime: " + playtimeHours + " hours");
        Debug.Log("secret item found: " + (hasFoundSecretItem ? "Yes" : "No"));
        Debug.Log("Quests Completed: " + questsCompleted);
        Debug.Log("Current Weapon: " + currentWeapon);
        Debug.Log("Items: " + healthPotions + " health potions, " + keys + " keys");
        Debug.Log("Tutorial Complete: " + hasCompletedTutorial);
        Debug.Log("========================");
    }
}