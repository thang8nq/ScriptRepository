using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //public Player player;
    public float lifeTime = 2; 

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check if the collider not trigger. 
        if(collision.isTrigger == false)
        {
            if(collision.CompareTag("Player"))
            {
                collision.SendMessageUpwards("Damage", 1);
            }
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
            Destroy(gameObject);
    }
}
