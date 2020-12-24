using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public float maxSpeed = 3.0f; 
    public float minSpeed = 1.0f; 
    public float speed = 2.0f; 

    public bool beHit = false; 
    public Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //random speed 
        speed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);

        //set state to switch animation
        anim.SetBool("beHit", beHit);
    }

    public void setHit(bool hit)    
    {
        Debug.Log("setHit");
        beHit = hit;
    }

    void OnDestroy()
    {

    }
}
