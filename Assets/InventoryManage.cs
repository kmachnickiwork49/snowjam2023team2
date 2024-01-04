using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManage : MonoBehaviour
{
    private int nSlots;
    public int currentSlot;
    // Start is called before the first frame update
    public GameObject[] Slots;
    void Start()
    {
        foreach(GameObject child in Slots){
            child.GetComponent<Image>().sprite = Resources.Load<Sprite>("whiteBox");
        }
        nSlots = Slots.Length;
        currentSlot = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int UpdateSlotNum(){
        if(currentSlot >= nSlots) currentSlot = 0;
        else currentSlot ++;
        return currentSlot;
    }
    public void DisplayItem(string ItemName){
        Slots[UpdateSlotNum()].GetComponent<Image>().sprite = Resources.Load<Sprite>(ItemName);
    }

    public void resetInventory(){
        currentSlot = -1;
        foreach(GameObject child in Slots){
            child.GetComponent<Image>().sprite = Resources.Load<Sprite>("whiteBox");
        }
    }
}
