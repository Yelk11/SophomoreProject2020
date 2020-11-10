using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code used from https://www.youtube.com/watch?v=9H-PtEtCVZM
public class PauseButtonScript : MonoBehaviour
{
    bool isPaused = false;

    public void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        } 
        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}
