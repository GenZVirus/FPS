using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAid : Pickup
{
    public override string GetPickupMessage()
    {
        return "Press F to pick up First Aid";
    }

    public override void applyEffect(GameObject player)
    {
        player.GetComponent<HealthScript>().Heal();
        player.GetComponent<PlayerStats>().Display_HealthStats(player.GetComponent<HealthScript>().health);
    }
}
