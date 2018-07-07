using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsManagerScript : MonoBehaviour
{
    // Setting up player stats
    public int currHealth, maxHealth, 
               currMana, maxMana, currXP, 
               abilityOneCooldown, abilityTwoCooldown, abilityThreeCooldown, ultimateCooldown,
               playerDamage, currArmor, attackSpeed, healthRegen, manaRegen, goldCount,
               abilityOneLevel, abilityTwoLevel, abilityThreeLevel, ultimateLevel;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void HeroUpdateEverySecond()
    {
        // We first heal up our hero with health regen
        currHealth += healthRegen;

        // We make sure we don't overheal
        if (currHealth > maxHealth)
            currHealth = maxHealth;

        // Next, we gain mana
        currMana += manaRegen;

        // We make sure we don't overheal
        if (currMana > maxMana)
            currMana = maxMana;

        // Next, we get a coin every second!
        goldCount += 1;

        // Finally, we decrease all of our ability cooldowns
        if (abilityOneCooldown != 0)
            abilityOneCooldown -= 1;
        if (abilityTwoCooldown != 0)
            abilityTwoCooldown -= 1;
        if (abilityThreeCooldown != 0) 
            abilityThreeCooldown -= 1;
        if (ultimateCooldown != 0)
            ultimateCooldown -= 1;
    }
}
