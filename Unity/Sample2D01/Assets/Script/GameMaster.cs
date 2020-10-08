using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameMaster : MonoBehaviour
{
    public Text scoreTxt;
    public int points;
    public int hightScore; 

    public Text pointText;
    public Text hightText;
    public Text inputText; 

    // Start is called before the first frame update
    void Start()
    {
        // get high score from local save 
        hightScore = PlayerPrefs.GetInt("highscore", 0);
        hightText.text = ("HighScore: " + hightScore);

        if(PlayerPrefs.HasKey("points"))
        {
            //get current screen 
            Scene activeScreen = SceneManager.GetActiveScene();

            if (activeScreen.buildIndex == 0)
            {
                PlayerPrefs.DeleteKey("points");
                points = 0; 
            }
            else
            {
                points = PlayerPrefs.GetInt("points");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Points: " + points; 
    }
}
