using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreenControl : MonoBehaviour
{
    private Slider Lslider;

    public float speed = 0.2f;
    private float Loadpoint = 0;

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
            SceneManager.LoadScene("Level 2");
    }

    public void Progress(float newProgress)
    {
        Loadpoint = Lslider.value + newProgress;
    }
}
