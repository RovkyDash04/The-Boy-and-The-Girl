using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDeath : MonoBehaviour
{

    public GameObject Player;
    public Transform RespawnPoint;

    //Identifies tag of attached Gameobject and if it comes into contatct with
    //gameobejct tagged "fire", removes attached object from screen then re places attached object at desginated location.

    //If water player touches fire, respawns player//
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.CompareTag("Fire"))
        {
            Player.transform.position = RespawnPoint.position;
        }
    }
}
