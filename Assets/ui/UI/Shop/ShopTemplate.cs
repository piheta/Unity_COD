using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopTemplate : MonoBehaviour
{
    public TMP_Text titleText;
    public TMP_Text priceText;
    public TMP_Text descriptionText;
    public PickupWithScriptableObject pickUpEffect;
    public GameObject player;

    public void BoughtEffect()
    {
        //sjekk om den de colliderer med er player

        pickUpEffect.Apply(player);
    }
}