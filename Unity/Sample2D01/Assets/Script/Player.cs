using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Player's attribute 
    public float speed = 50f, maxspeed = 3, jumpPow = 220f;

    // Component to change velocity, mass,... 
    public Rigidbody2D r2;


    // Check status of player on ground or not 
    public bool grounded = true;
    public Animator anim; 

	// Use this for initialization, call only once time
	void Start () {
        // Get component at 1st launch 
        r2 = gameObject.GetComponent<Rigidbody2D>();

        // Get animator at 1st launch 
        anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        // Link Grounded in Animator (from sence) to grounded in script -> update real time 
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(r2.velocity.x)); 
        
        // Jump when press Space & player on ground
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                grounded = false; // update image of player when jump (condition in state jump)
                r2.AddForce(Vector2.up * jumpPow);
            }
        }

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

        // Limit the player's speed 
        if (r2.velocity.x > maxspeed)
            r2.velocity = new Vector2(maxspeed, r2.position.y); 
        if(r2.velocity.x < -maxspeed)
            r2.velocity = new Vector2(-maxspeed, r2.position.y);
    }
}
