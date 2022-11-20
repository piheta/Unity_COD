using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour
{
    public static int player_money = 1000;
    public static int easter_eggs = 0;
    public GameObject poorLabel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        Debug.Log("money: " + player_money + " eggs: " + easter_eggs);
    }
}
