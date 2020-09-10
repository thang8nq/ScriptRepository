﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour
{
    public int dmg = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // the collider not a trigger & has tag "enemy"
        if(collision.isTrigger == false && collision.CompareTag("Enemy"))
        {
            collision.SendMessageUpwards("Damage", dmg);
        }
    }
}
