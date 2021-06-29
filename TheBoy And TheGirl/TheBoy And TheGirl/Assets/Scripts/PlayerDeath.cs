using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
    public Transform RespawnPoint;
    public Transform EnemyspawnPoint;
    public GameObject Player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            /*Destroy(gameObject);
            LevelManager.instance.Respawn();*/
            collision.transform.position = EnemyspawnPoint.position;
            Player.transform.position = RespawnPoint.position; 
        }
        if (collision.transform.CompareTag("EnemyPatrol"))
        {
            Player.transform.position = RespawnPoint.position;
            Debug.Log("I suck");
        }
    }

}
