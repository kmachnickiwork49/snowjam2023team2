using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextHandler : MonoBehaviour
{
    private ImageControl currentImage;
    private ItemManage currentItem;
    [SerializeField] private TMP_Text _text;

    // Start is called before the first frame update
    void Start()
    {
        currentImage = GameObject.Find("RoomImage").GetComponent<ImageControl>();
        currentItem = GameObject.Find("ItemManager").GetComponent<ItemManage>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeText();
    }

    void ChangeText(){
        if (currentImage.currentState == ImageControl.State.normal){
            _text.text = "";
        }else _text.text = "this is a " + currentItem.FeaturedItem;
    }
}
