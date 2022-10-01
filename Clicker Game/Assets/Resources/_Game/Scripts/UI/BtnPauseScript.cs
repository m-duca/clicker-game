using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnPauseScript : MonoBehaviour
{
    // Components
    private Image imgIcon;
    private AudioSource levelMusic;

    // Assets
    [SerializeField] private Sprite pauseIcon;
    [SerializeField] private  Sprite playIcon;


    public bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        imgIcon = transform.Find("ImgIcon").GetComponent<Image>();
        levelMusic = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void BtnPause(){
        if (!isPaused){
            // Pause
            isPaused = true;
            Time.timeScale = 0;
            imgIcon.sprite = playIcon;
            levelMusic.Pause();
        }else{
            // Play
            isPaused = false;
            Time.timeScale = 1;
            imgIcon.sprite = pauseIcon;
            levelMusic.Play();
        }
        
    }
}
