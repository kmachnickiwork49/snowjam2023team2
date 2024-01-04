using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    private ImageControl currentImage;
    // Start is called before the first frame update
    void Start()
    {
        currentImage = GameObject.Find("RoomImage").GetComponent<ImageControl>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown(){
        currentImage.CurrentRoom = currentImage.CurrentRoom + 1;
    }
}
