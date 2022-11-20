using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egg : MonoBehaviour
{
    public GameObject player;
    float Distance1;
    public GameObject obj1;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        Distance1 = Vector3.Distance(obj1.transform.position, player.transform.position);

        if (Distance1 < 1.5f){
            money.easter_eggs += 1;
            obj1.SetActive(false);
            audioSource.Play();
        } 
    }
}      
