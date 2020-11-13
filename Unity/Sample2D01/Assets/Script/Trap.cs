using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public Player player;
    public int damage = 1;
    public float timeInTrap = 0; 

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

        if (collision.CompareTag("Player"))
        {
            // first enter -> decrease 
            player.DecreaseHP(damage);

            //disable knockback
            //if (player.currentHP > 0)
            //    player.KnockBack(100f, player.transform.position);
        }
        else
        {
            Destroy(collision);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Invoke("updateTimeInTrap", Time.deltaTime);

            if (timeInTrap >= 100)
            {
                player.DecreaseHP(damage);
                timeInTrap = 0;
            }
        }
    }

    public void updateTimeInTrap()
    {
        timeInTrap += 1f;
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
         if(collision.CompareTag("Player"))
        {
            timeInTrap = 0; 
        }
    }
}
