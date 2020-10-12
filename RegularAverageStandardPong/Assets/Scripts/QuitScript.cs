using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Game has been Quit.");
        Application.Quit();
    }
}
