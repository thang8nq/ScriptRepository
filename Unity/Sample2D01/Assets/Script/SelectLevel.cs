using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class SelectLevel : MonoBehaviour
{
    public int maxLevel =  2; 
    public Text selectInfo; 

    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnLevelSelected(int levelIndex)
    {
        if(levelIndex > maxLevel)
        {
           selectInfo.text = ("We support to level " + maxLevel + " for now. Level " + levelIndex + " will be unlock soon. Regards!");
           return;
        }
        SceneManager.LoadScene(levelIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
