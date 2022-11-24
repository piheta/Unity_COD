using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InfimaGames.LowPolyShooterPack;


[CreateAssetMenu(menuName = "Powerups/AmmoBuff")]
public class AmmoBuff : PickupWithScriptableObject
{
    public int MainWeaponamount;
    public int SideWeaponamount;

    public override void Apply(GameObject target)
    {
        Weapon[] weapons = target.GetComponentsInChildren<Weapon>(true);
        weapons[0].ammunitionTotal = MainWeaponamount;
        weapons[1].ammunitionTotal = SideWeaponamount;
    }
}