using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScripts : MonoBehaviour
{
    private GameObject panelCredits;

    // Start is called before the first frame update
    void Start()
    {
        panelCredits = GameObject.Find("Canvas").transform.Find("PanelCredits").gameObject;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SetPanelCredits(bool state){
        panelCredits.SetActive(state);
    }
}
