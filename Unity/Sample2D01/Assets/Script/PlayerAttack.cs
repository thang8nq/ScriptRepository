using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackDelay = 0.3f; //time delay between attack 
    public bool isAttacking = false;

    public Animator anim; //switch between anim
    public Collider2D trigger;

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
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z) && !isAttacking)
        {
            isAttacking = true;
            trigger.enabled = true;
            attackDelay = 0.3f;
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
