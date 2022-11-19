using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] spawners;
    public GameObject enemy;
    // Start is called before the first frame update
    private void Start()
    {
        spawners = new GameObject[5];

        for (int i = 0; i < spawners.Length; i++) 
        {
            spawners[i] = transform.GetChild(i).gameObject;
            
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy() 
    {
        int spawnerID = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[spawnerID].transform.position, spawners[Random.Range(0, spawners.Length)].transform.rotation);
    }
}
