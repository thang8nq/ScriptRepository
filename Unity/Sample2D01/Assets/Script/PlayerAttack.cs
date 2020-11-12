using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAttack : MonoBehaviour
{
    public float attackDelay = 0.3f; //time delay between attack 
    public bool isAttacking = false;

    public Animator anim; //switch between anim
    public Collider2D trigger;
    public SoundManager soundManager;

    /// <summary>
    /// This func run BEFORE start()
    /// Always run no matter script enable or not 
    /// </summary>
    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        trigger.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.FindGameObjectWithTag("Sound").GetComponent<SoundManager>();
        Debug.Log(SceneManager.GetActiveScene().name);
        Debug.Log(soundManager);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z) && !isAttacking)
        {
            isAttacking = true;
            trigger.enabled = true;
            attackDelay = 0.3f;
            soundManager.PlaySound("sword");
        }

        // delay between attack times
        if(isAttacking)
        {
            if(attackDelay > 0)
            {
                attackDelay -= Time.deltaTime;
            }
            else
            {
                isAttacking = false;
                trigger.enabled = false;
            }
        }

        anim.SetBool("Attacking", isAttacking);
    }
}
