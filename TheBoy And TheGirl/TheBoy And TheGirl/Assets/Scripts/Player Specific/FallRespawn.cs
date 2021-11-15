using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallRespawn : MonoBehaviour
{
    public Transform spawnPoint; //Add empty gameobject as spawnPoint
    public float minHeightForDeath;
    public GameObject player; //Add your player

    //Continuously checks if player character is below manually set y-value
    //and if it is, setting it back at its respawn point
    void Update()
    {
        if (player.transform.position.y < minHeightForDeath)
            player.transform.position = spawnPoint.position;
    }
}
