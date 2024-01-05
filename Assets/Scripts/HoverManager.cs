using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverManager : MonoBehaviour
{
    [SerializeField] private GameObject[] ObjList;
    private ShowZoomedImage[] ZoomList;

    public bool isHoverable = true;

    void Start(){
        isHoverable = true;
        // for(int i = 0; i < ObjList.Length; i++){
        //     ZoomList[i] = ObjList[i].GetComponent<ShowZoomedImage>();
        // }
    }
    void Update(){
    }
}
