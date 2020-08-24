using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems; 

public class Menu : MonoBehaviour
{
    public bool pause = false;
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
        }

       pauseUI.SetActive(pause);
    }

    public void Resume()
    {
        Debug.Log("Resume");
        pause = false;
    }

    public void Restart()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void Quit()
    {
        Debug.Log("Quit");
        //Only work when build to apk, (not work in unity) 
        Application.Quit();
    }
}

 