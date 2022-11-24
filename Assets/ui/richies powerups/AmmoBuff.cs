using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InfimaGames.LowPolyShooterPack;


[CreateAssetMenu(menuName = "Powerups/AmmoBuff")]
public class AmmoBuff : PickupWithScriptableObject
{
    public int amount;

    public override void Apply(GameObject target)
    {
        target.GetComponentsInChildren<Weapon>()[0].ammunitionTotal += amount;
        //target.GetComponentsInChildren<Weapon>()[1].ammunitionTotal += amount;        
    }
}