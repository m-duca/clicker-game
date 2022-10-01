using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OreScript : MonoBehaviour
{
    public int oreLife = 0;
    
    private Text oreLifeText;

    private GameObject panelEnd;

    // Start is called before the first frame update
    void Start()
    {
        IgnoreTransparent();
        oreLifeText = transform.parent.Find("TxtOreLife").GetComponent<Text>();

        panelEnd = GameObject.Find("Canvas").transform.Find("PanelEnd").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        oreLifeText.text = oreLife.ToString();

        if (oreLife <= 0){
            oreLife = 0;
            panelEnd.SetActive(true);
        }
    }

    private void IgnoreTransparent(){
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = 0.1f;
    }
}
