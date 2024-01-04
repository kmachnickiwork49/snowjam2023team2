using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    private ImageControl currentImage;
    private InventoryManage inventoryBox;
    [SerializeField] private int requiredKeys;
    // Start is called before the first frame update
    void Start()
    {
        currentImage = GameObject.Find("RoomImage").GetComponent<ImageControl>();
        inventoryBox = GameObject.Find("Inventory").GetComponent<InventoryManage>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown(){
        if(ConditionPassed()){
            inventoryBox.resetInventory();
            currentImage.CurrentRoom = currentImage.CurrentRoom + 1;
        }
    }

    bool ConditionPassed(){
        Debug.Log(inventoryBox.currentSlot);
        if (inventoryBox.currentSlot == requiredKeys-1) return true;
        else {
            return false;
        }
    }
}
