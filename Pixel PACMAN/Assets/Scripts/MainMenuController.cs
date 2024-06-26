using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* SCRIPT: MainMenuController

 Created By:  Rodrigo Duran Daniel
 Created In:  27/03/2024
 Last Update: 02/04/2024

 Function: Dealing with MainMenu Scene

 */

public class MainMenuController : MonoBehaviour
{
    #region Methods

    //StartGame
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("Game");
    }

    //QuitGame
    public void QuitGame()
    {
        Application.Quit();
    }

    #endregion
}
