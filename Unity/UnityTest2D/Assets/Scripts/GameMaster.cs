using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public GameObject balloon;
    public float spawnInterval = 0.5f; 
    public float spawnTimeTotal;  

    // Start is called before the first frame update
    void Start()
    {
        
    
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimeTotal += Time.deltaTime;
        if(spawnTimeTotal > spawnInterval)
        {
            Debug.Log("spawn");
            SpawnBalloon();
            spawnTimeTotal = 0;
        }        
        else
        {
            Debug.Log("delay");
        }
    }

    void SpawnBalloon()
    {
        Vector2 randPos = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));

        // Instantiate at position (0, 0, 0) and zero rotation
        Instantiate(balloon, randPos, Quaternion.identity);
    }
}
