using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMainStay : MonoBehaviour
{
    public PickupWithScriptableObject pickUpEffect;

    private void OnTriggerStay(Collider collision)
    {
        //sjekk om den de colliderer med er player

        pickUpEffect.Apply(collision.gameObject);
    }
}