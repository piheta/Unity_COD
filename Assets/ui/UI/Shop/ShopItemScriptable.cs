using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Shop/ShopItem")]
public class ShopItemScriptable : ScriptableObject
{
    // Start is called before the first frame update
    public string title;
    public string description;
    public int baseCost;
    public int discount;
}
