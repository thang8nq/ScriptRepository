using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public float maxSpeed = 3.0f; 
    public float minSpeed = 1.0f; 
    public float speed = 2.0f; 

    // Start is called before the first frame update
    void Start()
    {
        //random speed 
        //speed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
