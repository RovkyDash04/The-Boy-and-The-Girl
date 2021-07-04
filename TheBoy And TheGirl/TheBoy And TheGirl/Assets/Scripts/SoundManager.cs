using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip DeathSound, JumpSound, CoinSound;
    static AudioSource audiosrc;

    // Start is called before the first frame update
    void Start()
    {

        JumpSound = Resources.Load<AudioClip>("Jump");
        DeathSound = Resources.Load<AudioClip>("Death");
        CoinSound = Resources.Load<AudioClip>("Money");

        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Jump":
                audiosrc.PlayOneShot(JumpSound);
                break;

            case "Death":
                audiosrc.PlayOneShot(DeathSound);
                break;

            case "Money":
                audiosrc.PlayOneShot(CoinSound);
                break;

        }
    }
}
