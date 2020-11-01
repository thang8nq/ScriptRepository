using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public GameObject balloon;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 randPos = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));

        // Instantiate at position (0, 0, 0) and zero rotation
        Instantiate(balloon, randPos, Quaternion.identity);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
