using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class LevelManager : MonoBehaviour {
    public static LevelManager instance;

    public Transform respawnPoint;
    public GameObject playerPrefab;

    public CinemachineVirtualCameraBase cam;

    [Header("Currency")]
    public int currency = 0;
    public Text currencyUI;

    private void Awake() {
        instance = this;
    }


    //Calls from SoundManager script to access sound files and keeps the player prefab while moving it back to the respawn location.
    public void Respawn() {
        SoundManager.PlaySound("Death");
        GameObject player = Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        cam.Follow = player.transform;
    }

    //Identifies manually set value of coins and adds it to the text on screen taht displays the toal collected, in front of a $ to signify money
    public void IncreaseCurrency(int amount)
    {
        currency += amount;
        currencyUI.text = "$" + currency;
    }

}
