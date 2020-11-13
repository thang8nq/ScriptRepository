using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Door : MonoBehaviour
{
    ///public int LevelLoad;
    public GameMaster gameMaster;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        gameMaster = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
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
        if(player.isAlive)
        {
            if (Input.GetKey(KeyCode.E))
            {
                SaveScore();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
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
