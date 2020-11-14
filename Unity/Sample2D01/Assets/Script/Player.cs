using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Player : MonoBehaviour {

    // Player's attribute 
    public float speed = 50f, maxspeed = 3, jumpPow = 220f;
    public bool isAlive = true; 

    // Component to change velocity, mass,... 
    public Rigidbody2D r2;

    // Player HP 
    public int currentHP, maxHP = 5; 

    // Check status of player on ground or not 
    public bool grounded = true, faceright = true, doublejump = false;
    public Animator anim;
    public GameMaster gameMaster;
    public SoundManager soundManager;

    public Menu menu; 

	// Use this for initialization, call only once time
	void Start () {
        // Get component at 1st launch 
        r2 = gameObject.GetComponent<Rigidbody2D>();

        // Get animator at 1st launch 
        anim = gameObject.GetComponent<Animator>();

        currentHP = maxHP;

        gameMaster = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
        soundManager = GameObject.FindGameObjectWithTag("Sound").GetComponent<SoundManager>();
        menu = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Menu>();
        Debug.Log("");
	}
	
	// Update is called once per frame
	void Update () {
        if(isAlive)
        {
            // Link Grounded in Animator (from sence) to grounded in script -> update real time 
            anim.SetBool("Grounded", grounded);
            anim.SetFloat("Speed", Mathf.Abs(r2.velocity.x));

            // Jump when press Space & player on ground
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (grounded)
                {
                    grounded = false; // update image of player when jump (condition in state jump)
                    doublejump = true;
                    r2.AddForce(Vector2.up * jumpPow);
                }
                // allow player double jump if in state jump (doublejump = true), but only 1 time
                else
                {
                    if (doublejump)
                    {
                        r2.velocity = new Vector2(r2.velocity.x, 0); // firstly, fixed the pos of player at the momment start 2nd jumping 
                        r2.AddForce(Vector2.up * jumpPow); // then, add a force for the 2nd jumping 
                    }
                    doublejump = false; //fix double jump 
                }
            }
        }

        if (currentHP <= 0)
            Death();
    }

    /// <summary>
    /// Update each 0.2s, relate to physic: the moving of player...
    /// </summary>
    private void FixedUpdate()
    {
        if(!menu.pause && isAlive)
        {
            // Get the direction of player (moving left[-1]/right[1]/ide[0]) 
            // When user press arrow or A/D key
            float directionX = Input.GetAxis("Horizontal");

            // Add a vector force to player to make it moving to left/right depend on directionX 
            // Vector2.right = (1;0) -> only affect to X direction {right, left, up, down}
            r2.AddForce((Vector2.right) * speed * directionX);

            // Limit the player's speed 
            if (r2.velocity.x > maxspeed)
                r2.velocity = new Vector2(maxspeed, r2.velocity.y); //fix issue when moving player, keep speed not position: pos->vec
            if (r2.velocity.x < -maxspeed)
                r2.velocity = new Vector2(-maxspeed, r2.velocity.y);

            // If player moving to the right, but face to the left -> flip 
            if (directionX < 0 && !faceright)
            {
                Flip();
            }

            if (directionX > 0 && faceright)
            {
                Flip();
            }

            // add mass when player on ground
            if (grounded)
            {
                r2.velocity = new Vector2(r2.velocity.x * 0.7f, r2.velocity.y); // decrease speed of player after each 0.2s
            }
        }
    }

    public void Flip()
    {
        faceright = !faceright; 
        Vector3 Scale;
        Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale; 
    }

    public void Death()
    {
        isAlive = false;
        //Move player to the beginning of scene when he die 
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        //update high score in local save
        if(PlayerPrefs.GetInt("highscore") < gameMaster.points)
        {
            PlayerPrefs.SetInt("highscore", gameMaster.points); 
        }
    }

    public void DecreaseHP(int amount)
    {
        if(!menu.pause)
        {
            currentHP -= amount;
            currentHP = currentHP < 0 ? 0 : currentHP;
        }
    }

    // Add force to push player back when collide trap 
    public void KnockBack(float KnockPow, Vector2 KnockDir)
    {
        float direction = r2.velocity.x / Mathf.Abs(r2.velocity.x);
        r2.AddForce(new Vector2(KnockDir.x * -100 * direction, KnockDir.y * KnockPow));
    }

    public void Damage(int dmg)
    {
        if (currentHP == 0)
            return; 
        currentHP -= dmg; 
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Coin"))
        {
            soundManager.PlaySound("coins");
            Destroy(collision.gameObject);
            gameMaster.points += 1; 
        }

        if(collision.CompareTag("Heart"))
        {
            Destroy(collision.gameObject);
            currentHP = (currentHP == maxHP) ? maxHP : ++currentHP; //increase currentHP before bind -> using ++currentHP
        }

        if(collision.CompareTag("Shoes"))
        {
            Destroy(collision.gameObject);
            maxspeed *= 2;
            speed *= 2;

            StartCoroutine(timecount(5)); //The ONLY WAY to call a Inumerator function -> StartCoroutine
        }
    }

    // wait after time, then do next command 
    IEnumerator timecount(float time)
    {
        yield return new WaitForSeconds(time);
        maxspeed /= 2;
        speed /= 2;
        yield return 0; 
    }
}
