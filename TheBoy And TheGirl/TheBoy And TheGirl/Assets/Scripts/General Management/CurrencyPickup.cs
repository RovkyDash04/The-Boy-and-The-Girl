using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CurrencyPickup : MonoBehaviour
{
    public int worth = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            SoundManager.PlaySound("Money");
            LevelManager.instance.IncreaseCurrency(worth);
            //SoundManager.PlaySound("Money");
        }
    }
}
