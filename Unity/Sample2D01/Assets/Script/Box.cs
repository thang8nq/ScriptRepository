using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int health = 100;
    public SoundManager soundManager;

    private void Start()
    {
        soundManager = GameObject.FindGameObjectWithTag("Sound").GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Damage(int damage)
    {
        health -= damage;
        if(health <= 0)
            soundManager.PlaySound("destroy");
    }
}
