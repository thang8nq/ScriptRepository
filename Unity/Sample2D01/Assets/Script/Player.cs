using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Player's attribute 
    public float speed = 50f, maxspeed = 3, jumpPow = 220f;

    // Component to change velocity, mass,... 
    public Rigidbody2D r2; 


	// Use this for initialization, call only once time
	void Start () {
        // Get component at 1st launch 
        r2 = gameObject.GetComponent<Rigidbody2D>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// Update each 0.2s, relate to physic: the moving of player...
    /// </summary>
    private void FixedUpdate()
    {
        // Get the direction of player (moving left[-1]/right[1]/ide[0]) 
        // When user press arrow or A/D key
        float directionX = Input.GetAxis("Horizontal");

        // Add a vector force to player to make it moving to left/right depend on directionX 
        // Vector2.right = (1;0) -> only affect to X direction {right, left, up, down}
        r2.AddForce((Vector2.right) * speed * directionX); 
    }
}
