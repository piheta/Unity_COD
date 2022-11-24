using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egg : MonoBehaviour
{
    public AudioSource pickup;
    public AudioSource scream;
    public AudioSource boss;
    public static bool startBoss = false;

public void hitEgg(){

        Destroy(gameObject);
        money.easter_eggs += 1;

        // play egg collect sound on all the eggs except the last one, the last one plays boss music.
        if(money.easter_eggs < 1){
            pickup.Play();
        } else {
            scream.Play();
            boss.Play();
            startBoss = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){

    }
}      
