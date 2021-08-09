using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDeath : MonoBehaviour
{

    public GameObject Player;
    public Transform RespawnPoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.CompareTag("Waters"))
        {
            Player.transform.position = RespawnPoint.position;
        }
    }
}
