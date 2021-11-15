using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip DeathSound, JumpSound, CoinSound;
    static AudioSource audiosrc;

    // Start is called before the first frame update
    //Finds audio files in resources folder, and stores them for use under appropraite viarbale names for use in other C# scripts
    void Start()
    {

        JumpSound = Resources.Load<AudioClip>("Jump");
        DeathSound = Resources.Load<AudioClip>("Death");
        CoinSound = Resources.Load<AudioClip>("Money");

        audiosrc = GetComponent<AudioSource>();
    }

    //Basically checks what is happening with the character on screen and what sound to play based on the action, such as jumping, dying, etc

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
