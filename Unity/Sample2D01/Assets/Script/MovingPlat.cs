using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{
    public float speed = 0.08f;
    public float changeDirection = -1;
    Vector3 Move; 
    // Start is called before the first frame update
    void Start()
    {
        Move = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        Move.x  += speed;
        transform.position = Move; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Ground"))
        {
            speed *= changeDirection;
        }
    }
}
