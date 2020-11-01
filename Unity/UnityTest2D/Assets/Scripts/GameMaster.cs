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
        //Handle click 
        HandleClick();

        //spawn balloon 
        spawnTimeTotal += Time.deltaTime;
        if(spawnTimeTotal > spawnInterval)
        {
            SpawnBalloon();
            spawnTimeTotal = 0;
        }        
    }

    void SpawnBalloon()
    {
        Vector2 randPos = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));

        // Instantiate at position (0, 0, 0) and zero rotation
        Instantiate(balloon, randPos, Quaternion.identity);
    }

    void HandleClick()
    {
        //left click
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            Collider2D hitCollider = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(pos));
            if(hitCollider != null && hitCollider.transform.tag == "Balloon")
                Destroy(hitCollider.gameObject);
        }
    }
}
