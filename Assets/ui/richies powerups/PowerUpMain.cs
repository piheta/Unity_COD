using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpRichie : MonoBehaviour
{
    public PickupWithScriptableObject pickUpEffect;

    private void OnTriggerEnter3D(Collider collision)
    {
        //sjekk om den de colliderer med er player
        Destroy(gameObject);
        pickUpEffect.Apply(collision.gameObject);
    }
}

