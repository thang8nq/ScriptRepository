﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAI : MonoBehaviour
{
    public int curHealth = 100;

    //handle distance 
    public float distance; //between turret vs player 
    public float wakeRange; //for turret awaking 

    //handle bullet attribute 
    public float shootInterval;
    public float bulletSpeed;
    public float bulletTimer;

    //turret attribute 
    public bool isAwoke = false;
    public bool isLookingRight = true;

    //others obj
    public GameObject bullet;
    public Transform target; //get pos of player, bind it in unity 
    public Animator anim; //animation of turret 
    public Transform shootPointL, shootPointR; //pos to shoot 

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RangeCheck(); 

        //setup turret's status base on code behind
        anim.SetBool("Awake", isAwoke);
        anim.SetBool("LookRight", isLookingRight);

        //get player's & set turret status (AI) 
        if(target.transform.position.x > transform.position.x)
        {
            isLookingRight = true; 
        }

        if(target.transform.position.x < transform.position.x)
        {
            isLookingRight = false; 
        }

        if(curHealth < 0)
        {
            Destroy(gameObject);
        }
    }

    void RangeCheck()
    {
        //caculate distance between player vs turret 
        distance = Vector2.Distance(transform.position, target.transform.position);

        //handle status turret base on distance with player
        if (distance <= wakeRange)
        {
            isAwoke = true;
        }
        else
        {
            isAwoke = false;
        }
    }

    public void Attack(bool attackright)
    {
        bulletTimer += Time.deltaTime;

        if (bulletTimer >= shootInterval)
        {
            Vector2 direction = target.transform.position - transform.position;
            direction.Normalize();

            if (attackright)
            {
                GameObject bulletclone;
                bulletclone = Instantiate(bullet, shootPointR.transform.position, shootPointR.transform.rotation) as GameObject;
                bulletclone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

                bulletTimer = 0;
            }

            if (!attackright)
            {
                GameObject bulletclone;
                bulletclone = Instantiate(bullet, shootPointL.transform.position, shootPointL.transform.rotation) as GameObject;
                bulletclone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

                bulletTimer = 0;
            }
        }
    }

    public void Damage(int dmg)
    {
        curHealth -= dmg; 
    }
}
