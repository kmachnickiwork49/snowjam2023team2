using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoverable : MonoBehaviour
{
    // Start is called before the first frame update
    private Color32 startColor;
    private HoverManager hoverCheck;

    void Start(){
        hoverCheck = GameObject.Find("HoverManager").GetComponent<HoverManager>();
    }

    void OnMouseEnter(){
        startColor = GetComponent<SpriteRenderer>().color;
        if(hoverCheck.isHoverable){
            GetComponent<SpriteRenderer>().color = new Color32(255, 213, 213, 255); //a tad red
        }
    }

    void OnMouseExit(){
        GetComponent<SpriteRenderer>().color = startColor;
    }

}
