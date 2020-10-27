using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    public Player player;

    public MovingPlat movingPlat;
    public Vector3 movpVec3; 

    // Use this for initialization
    void Start () {
        player = gameObject.GetComponentInParent<Player>();
        
        //Got null twice times,
        //1st: Add tag to wrong element (FallingPlat)
        //2nd: There are 2 different element have same tag: FallingPlat & MovingPlat -> remove tag from FallingPlat 
        movingPlat = GameObject.FindGameObjectWithTag("MovingPlat").GetComponent<MovingPlat>();
    }

    /// <summary>
    /// Checking collision between Box2D trigger with Box2D of wall to detect player on ground or not 
    /// </summary>
    void FixedUpdate () {
		
	}

    // Start impacting
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.isTrigger == false)
            player.grounded = true; 
    }

    // Continue impacting (on ground)
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.isTrigger == false || collision.CompareTag("Water"))
            player.grounded = true;

        if (collision.isTrigger == false && collision.CompareTag("MovingPlat"))
        {
            movpVec3 = player.transform.position;
            movpVec3.x += movingPlat.speed * 1.3f;
            player.transform.position = movpVec3; //update player pos follow moving of platform
        }
    }

    // End impacting
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.isTrigger == false || collision.CompareTag("Water"))
            player.grounded = false;
    }
}
