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
        target.GetComponentInChildren<Weapon>().ammunitionTotal += amount;
    }
}