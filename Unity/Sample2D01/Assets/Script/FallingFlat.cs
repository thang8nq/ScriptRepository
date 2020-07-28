using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFlat : MonoBehaviour {

    public Rigidbody2D r2;
    public float timeDelay = 2f; //time waiting before the flat falling 

	// Use this for initialization
	void Start () {
        r2 = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// when player impact to fallingflat
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the  collider is player, then make it falling 
        if(collision.collider.CompareTag("Player"))
        {
            StartCoroutine(fall()); // must use StartCoroutine with IEnumerator function
        }
    }

    /// <summary>
    /// only this way (using IEnumerator) then can use delay time
    /// </summary>
    /// <returns></returns>
    IEnumerator fall()
    {
        yield return new WaitForSeconds(timeDelay);
        r2.bodyType = RigidbodyType2D.Dynamic;
        yield return 0; 
    }
}
