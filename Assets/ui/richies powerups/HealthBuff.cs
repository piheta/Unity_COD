using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Powerups/HealthBuff")]
public class HealthBuff : PickupWithScriptableObject
{
    public float amount;

    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerManager>().health += amount;
    }
}
