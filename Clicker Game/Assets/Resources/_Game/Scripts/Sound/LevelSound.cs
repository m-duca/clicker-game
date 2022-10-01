using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSound : MonoBehaviour
{
    private AudioSource levelMusic;
    private AudioSource hitSong;


    // Start is called before the first frame update
    void Start()
    {
        levelMusic = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        hitSong = this.GetComponent<AudioSource>();

        levelMusic.volume = OptionsScript.universalVolume;
        hitSong.volume = OptionsScript.universalVolume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
