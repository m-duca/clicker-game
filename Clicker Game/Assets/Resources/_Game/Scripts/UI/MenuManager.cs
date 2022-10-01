using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private Animator edgesAnim;

    // Start is called before the first frame update
    void Start()
    {
        edgesAnim = GameObject.Find("Canvas").transform.Find("Edges").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ButtonPlay(){
        edgesAnim.Play("edges_closing");
    }

    public void ButtonExit(){
        Application.Quit();
    }

}
