using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InfimaGames.LowPolyShooterPack;

[CreateAssetMenu(menuName = "Shop/ShopItem/Ammunition")]
public class ShopItemScriptable : PickupWithScriptableObject
{
    // Start is called before the first frame update
    public string title;
    public string description;
    public int baseCost;
    public int discount;


    public int AmmunitionAmount;
    public int MagSizeAmount;
    public int FireRateAmount;
    public int HealAmount;

    public override void Apply(GameObject target)
    {
        target.GetComponentInChildren<Weapon>().ammunitionTotal += AmmunitionAmount;

        target.GetComponentInChildren<Weapon>().ammunitionMagMax += MagSizeAmount;

        target.GetComponentInChildren<Weapon>().roundsPerMinutes += FireRateAmount;

        target.GetComponentInChildren<PlayerManager>().health += HealAmount;
    }
}