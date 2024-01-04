using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManage : MonoBehaviour
{
    private ImageControl currentImage;

    public GameObject[] ObjectToManage;

    // Start is called before the first frame update
    void Start()
    {
        currentImage = GameObject.Find("RoomImage").GetComponent<ImageControl>();

    }

    void Update(){
        ManageObject();
    }

    void ManageObject(){
        //check if a room is not currently on display, then disable all objects of that room
        for (int i = 0; i < ObjectToManage.Length; i++){
            if(ObjectToManage[i].name == currentImage.GetComponent<SpriteRenderer>().sprite.name){
                ObjectToManage[i].SetActive(true);
            }else ObjectToManage[i].SetActive(false);
        }
    }
}
