using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    public GameObject player;
    float Distance1;
    public GameObject obj1;
    public GameObject shopMenu;
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
                shopMenu.SetActive(true);
                Time.timeScale = 0;
                
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                
            }
            if(shopMenu.activeSelf && Input.GetKeyDown(KeyCode.X)){
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
                shopMenu.SetActive(false);
            }

        } 
        else {
            label.SetActive(false);
        }  
    }
}      
