using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSound : MonoBehaviour
{
    private AudioSource menuMusic;


    // Start is called before the first frame update
    void Start()
    {
        menuMusic = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        menuMusic.volume = OptionsScript.universalVolume;
    }
}
