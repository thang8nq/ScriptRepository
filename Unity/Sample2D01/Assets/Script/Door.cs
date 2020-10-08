using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Door : MonoBehaviour
{
    public int LevelLoad = 1;
    public GameMaster gameMaster; 

    // Start is called before the first frame update
    void Start()
    {
        gameMaster = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            SaveScore();
            gameMaster.inputText.text = "Press E to enter";
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKey(KeyCode.E))
        {
            SaveScore();
            SceneManager.LoadScene(LevelLoad);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            gameMaster.inputText.text = "";
        }
    }

    void SaveScore()
    {
        PlayerPrefs.SetInt("points", gameMaster.points);
    }
}
