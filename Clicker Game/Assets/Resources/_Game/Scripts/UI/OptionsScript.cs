using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour
{   
    private GameObject panelOptions;

    // Components
    private Slider sliderSound;

    public static float universalVolume = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        panelOptions = GameObject.Find("Canvas").transform.Find("PanelOptions").gameObject;
        sliderSound = panelOptions.transform.Find("Sound").transform.Find("SliderSound").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        universalVolume = sliderSound.value;
    }



    public void SetPanelOptions(bool state){
        panelOptions.SetActive(state);
    }
}
