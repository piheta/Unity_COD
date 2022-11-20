using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ShopManager : MonoBehaviour
{
    public int coins;
    public TMP_Text coinsText;
    public ShopItemScriptable[] shopItemSO;
    public GameObject[] shopPanelGO;
    public ShopTemplate[] shopPanels;
    public Button[] myPurchaseButton;

    void Start()
    {
        coins = 500;
        for (int i = 0; i < shopItemSO.Length; i++)
        {
            shopPanelGO[i].SetActive(true);
        }
            coinsText.text = "Coins:" + coins.ToString();
        LoadPanels();
        CheckPurchasable();
        
    }

    public void AddCoins()
    {
        coins = coins + 100;
        coinsText.text = "Coins:" + coins.ToString();
        CheckPurchasable();
    }

    public void LoadPanels()
    {
        for(int i = 0; i < shopItemSO.Length; i++)
        {
            shopPanels[i].titleText.text = shopItemSO[i].title;
            shopPanels[i].priceText.text = "Coins:" + shopItemSO[i].baseCost.ToString();
            shopPanels[i].descriptionText.text = shopItemSO[i].description;
        }
    }

    public void CheckPurchasable()
    {
        for (int i = 0; i < shopItemSO.Length; i++)
        {
            if(coins >= shopItemSO[i].baseCost)
                myPurchaseButton[i].interactable = true;
            else
                myPurchaseButton[i].interactable = false;
        }
    }

    public void Purchase(int buttonNumber)
    {
        if(coins >= shopItemSO[buttonNumber].baseCost)
        {
            coins = coins - shopItemSO[buttonNumber].baseCost;
            coinsText.text = "Coins:" + coins.ToString();
            CheckPurchasable();
            print(shopItemSO[buttonNumber].title + " is bought");
        }
    }
}
