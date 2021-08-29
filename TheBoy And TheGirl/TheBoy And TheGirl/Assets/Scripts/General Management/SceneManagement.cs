using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneManagement : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            {
                SceneManager.LoadScene("Loading Screen");
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
