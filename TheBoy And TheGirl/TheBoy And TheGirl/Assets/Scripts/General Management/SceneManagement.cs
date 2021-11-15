using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneManagement : MonoBehaviour
{
    public static int x = 3; //Public static variable so can be easily accessed in other c# scripts without being destroyed or reset in between calls.

    //Checks to see if either player is touching the white traingle at the end of the level and adding one to the buildIndex that needs to be loaded.
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            {
                SceneManager.LoadScene("Loading Screen");
                x += 1;
            }
        }
    }

    //When the user clicks the play button on the main menu, the first level is loaded
    public void Begin()
    {
        SceneManager.LoadScene("Level 1");
    }

    //When the user clicks the controls button, directs user to controls menu screen
    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    //When the user is on the controls menu, the user is able to click the menu button and be taken back to the main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
