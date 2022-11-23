using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book : MonoBehaviour
{
    public GameObject player;
    float Distance1;
    public GameObject obj1;
    public GameObject label;
    public GameObject bookMenu;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        Distance1 = Vector3.Distance(obj1.transform.position, player.transform.position);

        if (Distance1 < 2f){
            label.SetActive(true); //open book label - show
            
            if (Input.GetKeyDown(KeyCode.E)) { 
                label.SetActive(false); // open book label - hide
                
                Time.timeScale = 0; //stop time
                audioSource.Play(); // book sound
                bookMenu.SetActive(true); //show book content
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                
            }
                                //wait for book exit
            if(Input.GetKeyDown(KeyCode.X)){
                bookMenu.SetActive(false);
                Time.timeScale = 1;
                Cursor.lockState = CursorLockMode.Locked;
            }

        } 
        else {
            label.SetActive(false);
        }  
    }
}      
