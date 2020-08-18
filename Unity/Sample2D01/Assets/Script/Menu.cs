using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private bool pause = false;
    public GameObject pauseUI; 

    // Start is called before the first frame update
    void Start()
    {
        pauseUI = GameObject.FindGameObjectWithTag("PauseUI");
        pauseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
            pauseUI.SetActive(pause);
        }
    }
}
