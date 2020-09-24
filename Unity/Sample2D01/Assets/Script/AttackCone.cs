using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCone : MonoBehaviour
{
    public TurretAI turretAI;
    public bool isPlayerOnTheRight;

    private void Awake()
    {
        turretAI = gameObject.GetComponentInParent<TurretAI>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            turretAI.Attack(isPlayerOnTheRight); 
        }
    }
}
