using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreboardScript : MonoBehaviour
{
    private static int MAX_SCORE = 10;
    public GameObject ball;
    public GameObject bonusBall;
    public GameObject scoreBoard;
    public GameObject p1Score;
    public GameObject p2Score;
    float p1;
    float p2;

    // Update is called once per frame
    void Update()
    {
        p1 = p1Score.transform.position.y;
        p2 = p2Score.transform.position.y;

        scoreBoard.GetComponent<UnityEngine.UI.Text>().text = p1 + "|" + p2;

        //Since CPU is left paddle in 1 player version, this fixes where you would be sent to the win screen if the CPU won.
        if (p1 >= MAX_SCORE && MainMenuScript.gameType)
        {
            SceneManager.LoadScene("LoseScene");
        }
        if (p2 >= MAX_SCORE && MainMenuScript.gameType)
        {
            SceneManager.LoadScene("WinScene");
        }

        // check for win
        if (p1 >= MAX_SCORE)
        {
            SceneManager.LoadScene("WinScene");
        }
        if (p2 >= MAX_SCORE)
        {
            SceneManager.LoadScene("LossScene");
        }
    }
}

