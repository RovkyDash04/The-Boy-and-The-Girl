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

    private void Start()
    {

    }

    private void Awake() {
        instance = this;
    }

    public void Respawn() {
        SoundManager.PlaySound("Death");
        GameObject player = Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        cam.Follow = player.transform;
    }

    public void IncreaseCurrency(int amount)
    {
        currency += amount;
        currencyUI.text = "$" + currency;
    }

}
