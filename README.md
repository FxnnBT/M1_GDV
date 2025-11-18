# M1 GDV — Game Development (MA)

Overzicht van opdrachten en scripts voor de Game Development module.

## Inhoud
- [Coin, Goomba en Ghost 2.1](#coin-goomba-en-ghost-21)
- [Stats 2.2](#stats-22)
- [Collisions 3.1](#collisions-31)
- [Fantasy opdracht 3.2C](#fantasy-opdracht-32c)
- [Coin pickup 4.2](#coin-pickup-42)
- [Healthbar 5.1A](#healthbar-51a)
- [WeaponSwitch 5.1B / Enum 5.1C](#weaponswitch-51b--enum-51c)
- [Health Pickup 5.2](#health-pickup-52)
- [Game 6.1](#game-61)
- [M2](#m2)
- [Random Items](#random-items)
---

## Coin, Goomba en Ghost 2.1
![Coinetc](images/coin21.gif "Coin/mario opdracht")

Beschrijving: Een coin (sphere) en objecten (cube, cylinder) laten bewegen — heen en weer bewegingen en animatie.  
Script: [coinpickup.cs](Assets/coinpickup.cs)

---

## Stats 2.2
![Stats](images/stats.gif "stats editor")

Beschrijving: Spelerstats aangepast en uitgebreid. Toetsen: E geeft 15 damage, K herstelt 15 HP.  
Script: [playerstats.cs](Assets/playerstats.cs)

---

## Collisions 3.1
![Collision foto](images/collision.gif "Collision")

Beschrijving: Werken met colliders, Rigidbody en Physics Materials om botsingen te beheersen.

---

## Fantasy opdracht 3.2C
![Fantasy foto](images/fantasy.png "Mijn fantasy opdracht")

Beschrijving: Oefening met strings en return-waarden.  
Script: [Fantasy.cs](Assets/Fantasy.cs)

---

## Coin pickup 4.2
![Pickup](images/coinpickup.gif "Coin pick up")

Beschrijving: Player pakt coin op; coin verdwijnt en geeft een debugbericht.  
Script: [coinpickup.cs](Assets/coinpickup.cs)

---

## Healthbar 5.1A
![Healthbar](images/healthbar.gif "HealtBar")

Beschrijving: Healthbar toont huidige health; reageert op schade en healing.  
Script: [healthbar.cs](Assets/Scripts/healthbar.cs)

---

## WeaponSwitch 5.1B / WeaponSwitchEnum 5.1C
![WeaponSwitch](images/weaponswitch.gif "Weapon Switch")
![WeaponSwitchEnum](images/enum.gif "WeaponSwitchEnum")

Beschrijving: Wisselen tussen wapens via toetsen 1–4. Variant met enum voor betere leesbaarheid.  
Scripts: [WeaponSwitch.cs](Assets/Scripts/WeaponSwitch.cs), [WeaponEnum.cs](Assets/Scripts/WeaponEnum.cs)

---

## Health Pickup 5.2
![HealtPickup](images/Healthpickup.gif "HealthPickup")

Beschrijving: Health pickups geven life terug wanneer de speler eroverheen loopt. Vereist speler health script.  
Scripts: [HealthPickup.cs](Assets/Scripts/HealthPickup.cs), [PlayerVarHealth.cs](Assets/Scripts/PlayerVarHealth.cs)

---

## Game 6.1
![Game](images/game.gif "Game")

Beschrijving: Mini-game waarbij alle coins verzameld moeten worden. Eindigen kan pas wanneer de speler volle health heeft. Gebruikt meerdere scripts (coin pickup, health pickup, player health).  
Scripts: [PlayerVarHealth.cs](Assets/Scripts/PlayerVarHealth.cs), [HealthPickup.cs](Assets/Scripts/HealthPickup.cs), [coinpickup.cs](Assets/coinpickup.cs)

---

# M2

---

## Random items
![randomitem](images/random_items.gif "randomitems")

Beschrijving: Herhaling van datatypes en we hebben met private gewerkt en random items in de console laten appearen als je op een bepaald knop klikt. ik heb nmr1 voor een willekeurig item, en nmr 2 voor alle items
Script: [Randomitems](Assets/Scripts/randomitems.cs)

