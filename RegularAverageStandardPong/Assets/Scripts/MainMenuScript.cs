using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{   
    //TODO: Add all of the appropriate variables and calls that make the second Paddle automated.
    public void StartGameSinglePlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //TODO: Add all of the appropriate variables and calls that make the second Paddle useable with controls.
    //      (I'm thinking WASD for main paddle, Arrow keys for second paddle when it's active)
    public void StartGameTwoPlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Debug.Log("Game has been Quit.");
        Application.Quit();
    }
}
