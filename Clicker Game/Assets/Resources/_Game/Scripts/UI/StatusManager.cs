using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour
{
    // Components
    private List<Image> imgPickaxeIngots = new List<Image>();
    private List<Image> imgHelperIngots = new List<Image>();

    private Image imgBoxPickaxe;

    // Assets
    private Sprite sprGoldIngot;
    private Sprite sprEmptyIngot;


    [Header("Status Settings:")]
    [Range(0, 5)] public int pickaxeGoldIngots = 0;
    [Range(0, 5)] public int helperGoldIngots = 0;

    void Awake()
    {
        GetIngotSprites();
        GetImages();
        
        SetBoxPickaxe();

        SetIngots(imgPickaxeIngots, pickaxeGoldIngots);
        SetIngots(imgHelperIngots, helperGoldIngots);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void SetIngots(List<Image> ingots, int goldIngots){
        for (int i = 0; i < ingots.Count; i++){
            Image curImage = ingots[i];
            if (i < goldIngots){
                curImage.sprite = sprGoldIngot;
            }else{
                curImage.sprite = sprEmptyIngot;
            }
        }
    }

    private void GetIngotSprites(){
        sprGoldIngot = Resources.Load("_Game/Art/Sprites/ingot_gold", typeof(Sprite)) as Sprite;
        sprEmptyIngot = Resources.Load("_Game/Art/Sprites/ingot_empty", typeof(Sprite)) as Sprite;
    }

    private void GetImages(){
        GameObject pickaxeIngots = GameObject.Find("Canvas").transform.Find("PanelStatus").transform.Find("Status Pickaxe").transform.Find("Pickaxe Ingots").gameObject;
        GameObject helperIngots = GameObject.Find("Canvas").transform.Find("PanelStatus").transform.Find("Status Helper").transform.Find("Helper Ingots").gameObject;


        // Pickaxe
        foreach(Transform child in pickaxeIngots.transform){
            imgPickaxeIngots.Add(child.GetComponent<Image>());
        }
        
        // Helper
        foreach (Transform child in helperIngots.transform){
            imgHelperIngots.Add(child.GetComponent<Image>());
        }
        
    }


    private void SetBoxPickaxe(){
        imgBoxPickaxe = GameObject.Find("Canvas").transform.Find("PanelStatus").transform.Find("Status Pickaxe").transform.Find("ImgBoxPickaxe").transform.Find("ImgCurPickaxe").GetComponent<Image>();
        
        switch(pickaxeGoldIngots){
            case 0:
                imgBoxPickaxe.sprite = Resources.Load("_Game/Art/Sprites/Pickaxes/pickaxe_stone", typeof(Sprite)) as Sprite;
            break;
            case 1:
                imgBoxPickaxe.sprite = Resources.Load("_Game/Art/Sprites/Pickaxes/pickaxe_cooper", typeof(Sprite)) as Sprite;
            break;
            case 2:
                imgBoxPickaxe.sprite = Resources.Load("_Game/Art/Sprites/Pickaxes/pickaxe_iron", typeof(Sprite)) as Sprite;
            break;
            case 3:
                imgBoxPickaxe.sprite = Resources.Load("_Game/Art/Sprites/Pickaxes/pickaxe_gold", typeof(Sprite)) as Sprite;
            break;
            case 4:
                imgBoxPickaxe.sprite = Resources.Load("_Game/Art/Sprites/Pickaxes/pickaxe_diamond", typeof(Sprite)) as Sprite;
            break;
            case 5:
                imgBoxPickaxe.sprite = Resources.Load("_Game/Art/Sprites/Pickaxes/pickaxe_ruby", typeof(Sprite)) as Sprite;
            break;
        }
    }

}
