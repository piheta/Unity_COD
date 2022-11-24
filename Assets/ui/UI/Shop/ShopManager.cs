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
    //public GameObject player;

    void Start()
    {

        for (int i = 0; i < shopItemSO.Length; i++)
        {
            shopPanelGO[i].SetActive(true);
        }
        coinsText.text = "Coins:" + coins.ToString();
        LoadPanels();
        CheckPurchasable();

    }

    void Update()
    {
        CheckPurchasable();
    }

    public void AddCoins()
    {
        money.player_money = money.player_money + 100;
        CheckPurchasable();
    }

    public void LoadPanels()
    {
        for (int i = 0; i < shopItemSO.Length; i++)
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
            if (money.player_money >= shopItemSO[i].baseCost)
                myPurchaseButton[i].interactable = true;
            else
                myPurchaseButton[i].interactable = false;
        }
    }

    public void Purchase(int buttonNumber)
    {
        if (money.player_money >= shopItemSO[buttonNumber].baseCost)
        {
            money.player_money = money.player_money - shopItemSO[buttonNumber].baseCost;
            CheckPurchasable();
            print(shopItemSO[buttonNumber].title + " is bought");
        }
    }

    public void PurchasePlayerEffect(int buttonNumber)
    {
        if (money.player_money >= shopItemSO[buttonNumber].baseCost)
        {
            money.player_money = money.player_money - shopItemSO[buttonNumber].baseCost;
            coinsText.text = "Coins:" + coins.ToString();
            CheckPurchasable();
            shopPanels[buttonNumber].BoughtEffect();
        }
    }

}
