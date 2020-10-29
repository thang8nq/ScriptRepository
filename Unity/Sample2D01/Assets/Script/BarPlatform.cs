using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarPlatform : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D collision)
    {
          if(collision.collider.CompareTag("Player"))
          {
            //When player stand on BarPlatform, if press S or downarrow, then disable (uncheck) boxcollider2d from BarPlatform
            //this make player can fall down
            if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                    gameObject.GetComponent<Collider2D>().enabled = false; 
            }
          }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            //Call func after delta seconds (this case: 0.5 seconds)
            Invoke("Restore", 0.5f);
        }
    }

    void Restore()
    {
        gameObject.GetComponent<Collider2D>().enabled = true; 
    }
}
