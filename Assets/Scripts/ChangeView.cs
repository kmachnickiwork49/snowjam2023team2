using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour
{
    private ImageControl currentImage;
    private ItemManage currentItem;
    [SerializeField] private string objectName;

    // Start is called before the first frame update
    void Start()
    {
        currentImage = GameObject.Find("RoomImage").GetComponent<ImageControl>();
        currentItem = GameObject.Find("ItemManager").GetComponent<ItemManage>();
    }

    void OnMouseDown(){
        //when clicked,
        //change image control state to "changeView"
        //update what item is being featured
        //display the said item
        currentImage.currentState = ImageControl.State.changeView;
        currentItem.FeaturedItem = objectName;
        currentImage.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ObjectsZoomed/"+objectName);
    }
}
