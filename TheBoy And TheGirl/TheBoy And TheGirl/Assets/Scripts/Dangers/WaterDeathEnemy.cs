using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDeathEnemy : MonoBehaviour {

    public GameObject Player;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.CompareTag("Waters"))
        {
            Destroy(Player);
        }
    }
}
