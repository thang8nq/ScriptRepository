using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpUI : MonoBehaviour
{
    public Sprite[] HpSprite;

    //We will update HP UI base on player's HP (currentHP)
    public Player player;

    // this is var's name of image in unity 
    public Image heart; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        // currentHP = 5 -> image 5 (6th) 
        // currentHP = 0 -> image 0 (1st)
        Debug.Log(player.currentHP);
        heart.sprite = HpSprite[player.currentHP];
    }
}
