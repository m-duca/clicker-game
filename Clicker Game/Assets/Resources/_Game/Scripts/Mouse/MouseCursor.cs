using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseCursor : MonoBehaviour
{
    private Texture2D cursorTexture;
    private PickaxeAndHelper gameManagerScript;

    void Awake()
    {
        if (SceneManager.GetActiveScene().name != "Menu"){
            gameManagerScript = GameObject.Find("Game Manager").GetComponent<PickaxeAndHelper>();
        }
        
        GetCursorTexture();


        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void GetCursorTexture(){
        if (SceneManager.GetActiveScene().name != "Menu"){
            switch(GameObject.Find("Game Manager").GetComponent<StatusManager>().pickaxeGoldIngots){
                case 0:
                    cursorTexture = Resources.Load("_Game/Textures/Mouse Cursors/Pickaxes/mouse_cursor_pickaxe_stone", typeof(Texture2D)) as Texture2D;
                    gameManagerScript.pickaxeDamage = 1;
                    gameManagerScript.clickPickaxePath = "_Game/Art/Sprites/Clicks/Pickaxes/click_pickaxe_stone";
                break;
                case 1:
                    cursorTexture = Resources.Load("_Game/Textures/Mouse Cursors/Pickaxes/mouse_cursor_pickaxe_cooper", typeof(Texture2D)) as Texture2D;
                    gameManagerScript.pickaxeDamage = 2;
                    gameManagerScript.clickPickaxePath = "_Game/Art/Sprites/Clicks/Pickaxes/click_pickaxe_cooper";
                break;
                case 2:
                    cursorTexture = Resources.Load("_Game/Textures/Mouse Cursors/Pickaxes/mouse_cursor_pickaxe_iron", typeof(Texture2D)) as Texture2D;
                    gameManagerScript.pickaxeDamage = 3;
                    gameManagerScript.clickPickaxePath = "_Game/Art/Sprites/Clicks/Pickaxes/click_pickaxe_iron";
                break;
                case 3:
                    cursorTexture = Resources.Load("_Game/Textures/Mouse Cursors/Pickaxes/mouse_cursor_pickaxe_gold", typeof(Texture2D)) as Texture2D;
                    gameManagerScript.pickaxeDamage = 4;
                    gameManagerScript.clickPickaxePath = "_Game/Art/Sprites/Clicks/Pickaxes/click_pickaxe_gold";
                break;
                case 4:
                    cursorTexture = Resources.Load("_Game/Textures/Mouse Cursors/Pickaxes/mouse_cursor_pickaxe_diamond", typeof(Texture2D)) as Texture2D;
                    gameManagerScript.pickaxeDamage = 5;
                    gameManagerScript.clickPickaxePath = "_Game/Art/Sprites/Clicks/Pickaxes/click_pickaxe_diamond";
                break;
                case 5:
                    cursorTexture = Resources.Load("_Game/Textures/Mouse Cursors/Pickaxes/mouse_cursor_pickaxe_ruby", typeof(Texture2D)) as Texture2D;
                    gameManagerScript.pickaxeDamage = 6;
                    gameManagerScript.clickPickaxePath = "_Game/Art/Sprites/Clicks/Pickaxes/click_pickaxe_ruby";
                break;
            }
        }else{
            cursorTexture = Resources.Load("_Game/Textures/Mouse Cursors/mouse_cursor_glove", typeof(Texture2D)) as Texture2D;
        }
        
    }
}
