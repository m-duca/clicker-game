using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void NextLevel(){
        switch (SceneManager.GetActiveScene().name){
            case "Menu":
                SceneManager.LoadScene("Level1");
            break;
            case "Level1":
                SceneManager.LoadScene("Level2");
            break;
            case "Level2":
                SceneManager.LoadScene("Level3");
            break;
            case "Level3":
                SceneManager.LoadScene("Level4");
            break;
            case "Level4":
                SceneManager.LoadScene("Level5");
            break;
            case "Level5":
                SceneManager.LoadScene("Level6");
            break;
            case "Level6":
                Application.Quit();
            break;
        }
    }
}
