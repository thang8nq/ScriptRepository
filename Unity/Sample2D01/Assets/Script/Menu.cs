using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems; 

public class Menu : MonoBehaviour
{
    public bool pause = false;
    public bool isPlayerDied = false; 

    public GameObject pauseUI;
    public GameObject deadUI; 
    public Player player; 

    // Start is called before the first frame update
    void Start()
    {
        pauseUI = GameObject.FindGameObjectWithTag("PauseUI");
        deadUI = GameObject.FindGameObjectWithTag("DeadUI");
        pauseUI.SetActive(false);
        deadUI.SetActive(false);

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
       
       if(player.isAlive && Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
        }

        if (player.currentHP == 0)
        {
            isPlayerDied = true; 
        }

        pauseUI.SetActive(pause);
        deadUI.SetActive(isPlayerDied);

        
    }

    public void Resume()
    {
        pause = false;
        isPlayerDied = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void Quit()
    {
        //Only work when build to apk, (not work in unity) 
        Application.Quit();
    }
}

 