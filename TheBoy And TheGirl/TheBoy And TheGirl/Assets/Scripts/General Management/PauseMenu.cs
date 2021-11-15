using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu: MonoBehaviour
{
    public static bool Paused = false;

    public GameObject PauseMenuUI;
    
    //Checks if Escape button is pressed, and either resumes the game if already paused, or pauses the game    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Resume();
            } else
            {
                DoPause();
            }
        }
    }

    //Sets the game's time to running, allowing the game to run, and disables the menu that shows up when paused, connected to resume button on pause menu
   public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    //Sets the game's time to not running, stopping the game from running, and enabling the pause menu to show. Connected to clicking escape button
    public void DoPause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }

    // Loads up Main menu screen, connected to menu button on main screen
    public void OnMenu()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
}
