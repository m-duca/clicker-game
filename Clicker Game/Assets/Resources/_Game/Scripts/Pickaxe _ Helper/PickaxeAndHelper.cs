using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickaxeAndHelper : MonoBehaviour
{
    [HideInInspector] public int pickaxeDamage = 0;
    private int helpersNum = 0;

    private OreScript oreScript;


    private float curHelperTime = 0;
    private int maxHelperTime = 4;


    [HideInInspector] public string clickPickaxePath;

    // Components
    private AudioSource hitAudio;
    private Transform fadeSpawnPos;

    private BtnPauseScript btnPauseScr;

    // Prefabs
    private GameObject fadeClick;


    


    // Start is called before the first frame update
    void Start()
    {
        helpersNum = this.GetComponent<StatusManager>().helperGoldIngots;
        oreScript = GameObject.Find("Canvas").transform.Find("Ore").transform.Find("BtnOre").GetComponent<OreScript>();

        fadeClick = Resources.Load("_Game/Prefabs/Pickaxe & Helper/Fade Click", typeof(GameObject)) as GameObject;
        fadeSpawnPos = GameObject.Find("Fade Spawn Pos").transform;

        btnPauseScr = GameObject.Find("Canvas").transform.Find("PanelStatus").transform.Find("BtnPause").GetComponent<BtnPauseScript>();

        hitAudio = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Helpers Attack
        if (helpersNum > 0 && oreScript.oreLife > 0){
            curHelperTime += Time.deltaTime;
            if (curHelperTime >= maxHelperTime){
                curHelperTime = 0;
                maxHelperTime = Random.Range(2, 6);
                oreScript.oreLife -= 1 * helpersNum;
                hitAudio.Play();
                CreateFadeClick("_Game/Art/Sprites/Clicks/Helper/click_helper_"+helpersNum.ToString());
            }
        }
        
    }



    public void BtnOre(){
        if (oreScript.oreLife > 0 && btnPauseScr.isPaused == false){
            if (Random.Range(0, 100) < 85){
                oreScript.oreLife -= pickaxeDamage;
                CreateFadeClick(clickPickaxePath);
                hitAudio.Play();
            }else{
                CreateFadeClick("_Game/Art/Sprites/Clicks/click_fail");
            }
        }   
    }


    private void CreateFadeClick(string path){
        GameObject fade = Instantiate(fadeClick, fadeSpawnPos.position + new Vector3(Random.Range(-1f, 1f), 0, 0), Quaternion.identity);
        fade.GetComponent<SpriteRenderer>().sprite = Resources.Load(path, typeof(Sprite)) as Sprite;
    }

}
