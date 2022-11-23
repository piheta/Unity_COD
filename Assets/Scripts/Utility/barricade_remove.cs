using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barricade_remove : MonoBehaviour
{
    public GameObject player;
    float Distance1;
    public GameObject obj1;
    public GameObject label;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        Distance1 = Vector3.Distance(obj1.transform.position, player.transform.position);

        if (Distance1 < 3f){
            label.SetActive(true);
            
            if (Input.GetKeyDown(KeyCode.E) && money.player_money >= 500) { 
                obj1.SetActive(false);
                label.SetActive(false);
                money.player_money -= 500;
                audioSource.Play();
            }

        } 
        else {
            label.SetActive(false);
        }  
    }
}      
