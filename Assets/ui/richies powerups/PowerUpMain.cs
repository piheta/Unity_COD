using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMain : MonoBehaviour
{
    public PickupWithScriptableObject pickUpEffect;

    private void OnTriggerEnter(Collider collision)
    {
        //sjekk om den de colliderer med er player

        pickUpEffect.Apply(collision.gameObject);
        Destroy(gameObject);
    }
}

