using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{
    public float speed = 0.08f;
    public float changeDirection = -1;
    Vector3 Move;

    public Menu menu; 
    
    // Start is called before the first frame update
    void Start()
    {
        Move = transform.position;

        menu = GameObject.FindGameObjectWithTag("MainCamera").GetComponentInParent<Menu>();
    }

    // Update is called once per frame
    void Update()
    {
        if(menu.pause)
        {
            this.transform.position = this.transform.position; 
        }
        else
        {
            Move.x += speed;
            transform.position = Move;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Ground"))
        {
            speed *= changeDirection;
        }
    }
}
