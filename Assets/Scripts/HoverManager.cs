using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverManager : MonoBehaviour
{
    [SerializeField] private GameObject[] ObjList;
    private ShowZoomedImage[] ZoomList;

    public bool isHoverable;

    void Start(){
        // for(int i = 0; i < ObjList.Length; i++){
        //     ZoomList[i] = ObjList[i].GetComponent<ShowZoomedImage>();
        // }
    }
    void Update(){
        for(int i = 0; i < ObjList.Length; i++){
            if(ObjList[i].GetComponent<ShowZoomedImage>().go_object.activeSelf) isHoverable = false;
            else isHoverable = true;
        }
    }
}
