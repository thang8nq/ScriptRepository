﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    public Player player; 

	// Use this for initialization
	void Start () {
        player = gameObject.GetComponentInParent<Player>();
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
    }

    // End impacting
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.isTrigger == false || collision.CompareTag("Water"))
            player.grounded = false;
    }
}
