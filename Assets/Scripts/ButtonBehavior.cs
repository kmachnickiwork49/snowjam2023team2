using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{
    public enum ButtonID{
        returnButton
    };

    public ButtonID ThisButtonID;

    private ImageControl currentImage;
    [SerializeField] private Text _text;
    
    void Start()
    {
        currentImage = GameObject.Find("RoomImage").GetComponent<ImageControl>();
    }

    // Update is called once per frame
    void Update()
    {
        ToggleDisplay();
    }

    void ToggleDisplay(){
        //Disabling the button
        if (currentImage.currentState == ImageControl.State.normal && ThisButtonID == ButtonID.returnButton){
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, 0);
            _text.text = "";
            GetComponent<Button>().enabled = false;
            this.transform.SetSiblingIndex(0);
        }

        //Enabling the button
        if (currentImage.currentState == ImageControl.State.changeView && ThisButtonID == ButtonID.returnButton){
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, 1);
            _text.text = "Return";
            GetComponent<Button>().enabled = true;
        }
    }
}
