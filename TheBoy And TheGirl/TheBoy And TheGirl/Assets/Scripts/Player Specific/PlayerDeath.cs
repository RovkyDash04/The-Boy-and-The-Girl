using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
    public static int health;
    public Transform RespawnPoint;
    public Transform EnemyspawnPoint;
    public GameObject Player;
    public GameObject GOMenuUI;
    public Animator anim;

    //Sets the amount of times the characters can die before being reset to start of level
    void Start()
    {
        health = 5;
    }

    //Identifies tag of Player character and if it comes into contatct with
    //gameobejct tagged "enemy", removes player character from screen then re places at desginated location.
    //Also decreases the number of lives left in play, while also displaying number left in console
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            collision.transform.position = EnemyspawnPoint.position;
            Player.transform.position = RespawnPoint.position;
            health = health - 1;
            Debug.Log(health);
        }
        if (collision.transform.CompareTag("EnemyPatrol"))
        {
            Player.transform.position = RespawnPoint.position;
            health = health - 1;
            Debug.Log(health);
        }
    }

    //Checks if the number of lives left is less than one, and then shows the game over menu if it is leass than one.
    private void Update()
    {
        if (health < 1)
        {
            Time.timeScale = 0f;
            GOMenuUI.SetActive(true);
        }
    }

}

//PLEASE NOTE: THIS FUNCTION WAS IN PROGRESS OF INTEGRATION BUT WAS NOT SUCCESSFULLY INTEGRATED INTO GAME BY TIME LIMIT.
