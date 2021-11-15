using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject GOMenuUI;
    public void OnMenu()
    {
        GOMenuUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
    public void Retry()
    {
        GOMenuUI.SetActive(false);
        SceneManager.LoadScene("Level 1");
        Time.timeScale = 1f;
        PlayerDeath.health = 5;
    }
}
