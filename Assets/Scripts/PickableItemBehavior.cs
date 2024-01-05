using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItemBehavior : MonoBehaviour
{
    [SerializeField] public string ItemName;
    private InventoryManage inventoryBox;
    private HoverManager hoverManager;

    // Start is called before the first frame update
    void Start()
    {
        inventoryBox = GameObject.Find("Inventory").GetComponent<InventoryManage>();
        hoverManager = GameObject.Find("HoverManager").GetComponent<HoverManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        if(hoverManager.isHoverable){
            inventoryBox.DisplayItem(ItemName);
            Destroy(gameObject);
        }
    }
}
