using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    private ImageControl currentImage;

    // Start is called before the first frame update
    void Start()
    {
        currentImage = GameObject.Find("RoomImage").GetComponent<ImageControl>();
    }

    public void OnClick(){
        currentImage.CurrentRoom = currentImage.CurrentRoom + 1;
        currentImage.currentState = ImageControl.State.normal;
    }

    public void OnReturnClick(){
        currentImage.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("RoomPics/room" + currentImage.CurrentRoom.ToString());
        currentImage.currentState = ImageControl.State.normal;
    }

}
