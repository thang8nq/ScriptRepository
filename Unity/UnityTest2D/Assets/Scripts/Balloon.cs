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
    }


    //there is only 1 direction for transition: from balloon alive -> balloon pop (beHit: false -> true)
    //therefore, we only call setHit when balloon was clicked on & switch it to pop state -> optimize code & performance
    public void setHit()    
    {
        //set state to switch animation
        anim.SetBool("beHit", true);

        //get time during animation, but it sime not work for Invoke
        //float time = anim.GetCurrentAnimatorClipInfo(0)[0].clip.length;

        //Just hardcode, and find this time is ok (0.3 second) ^^
        Invoke("DestroyBalloon", 0.3f);
    }

    public void DestroyBalloon()
    {
        Destroy(this.gameObject);
    }

    void OnDestroy()
    {

    }
}
