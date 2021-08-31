using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreenControl : MonoBehaviour
{
    private Slider Lslider;
    public GameObject Gameobject;

    public float speed = 0.2f;
    private float Loadpoint = 0;
    public string LevelName;

    private void Awake()
    {
        Lslider = gameObject.GetComponent<Slider>();
    }
    void Start()
    {
        Progress(1f);
    }

    void Update()
    {
        if (Lslider.value < Loadpoint)
            Lslider.value += speed * Time.deltaTime;

        if (Lslider.value == Loadpoint)
        {
            SceneManager.LoadScene(LevelName);
        }
        Destroy(Gameobject);
    }

    public void Progress(float newProgress)
    {
        Loadpoint = Lslider.value + newProgress;
    }
}
