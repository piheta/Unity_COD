using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egg : MonoBehaviour
{
    float Distance1;
    public AudioSource audioSource;

    public void hitEgg(){
        Destroy(gameObject);
        money.easter_eggs += 1;
        audioSource.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){

    }
}      
