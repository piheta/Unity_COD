using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_boss : MonoBehaviour
{
    public GameObject zobmie;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(egg.startBoss){
            zobmie.SetActive(true);
        }
    }
}
