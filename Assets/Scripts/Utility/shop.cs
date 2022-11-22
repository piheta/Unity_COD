using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    public GameObject player;
    float Distance1;
    public GameObject obj1;
    public GameObject label;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        Distance1 = Vector3.Distance(obj1.transform.position, player.transform.position);

        if (Distance1 < 5f){
            label.SetActive(true);
            
            if (Input.GetKeyDown(KeyCode.E)) { 
                //open shopwindow
            }

        } 
        else {
            label.SetActive(false);
        }  
    }
}      
