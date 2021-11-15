using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDeath : MonoBehaviour {

    public GameObject Player;
    public Transform RespawnPoint;

    //Identifies tag of attached Gameobject and if it comes into contatct with
    //gameobejct tagged "water", removes attached object from screen then re places attached object at desginated location.

    //If fire player touches water, respawns player//
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.CompareTag("Waters"))
        {
            Player.transform.position = RespawnPoint.position;
        }
    }
}
