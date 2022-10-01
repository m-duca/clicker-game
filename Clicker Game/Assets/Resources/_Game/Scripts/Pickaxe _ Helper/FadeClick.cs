using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeClick : MonoBehaviour
{
    // Components
    private SpriteRenderer spr;
    
    
    [SerializeField] private float speedY = 0;

    // Start is called before the first frame update
    void Start()
    {
        spr = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += (Vector3.up * speedY) * Time.deltaTime;

        Color sprColor = spr.color;
        sprColor.a -= Time.deltaTime;
        spr.color = sprColor;
        if (spr.color.a <= 0){
            Destroy(gameObject);
        }

    
    }
}
