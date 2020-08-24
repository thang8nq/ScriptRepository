using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public Player player; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When player collide to trap
    // use OnTriggerStay2D if want take effect when player stand on trap 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter2d");
        if(collision.CompareTag("Player"))
        {
            player.DecreaseHP(1);
            player.KnockBack(350f, player.transform.position);
        }
    }
}
