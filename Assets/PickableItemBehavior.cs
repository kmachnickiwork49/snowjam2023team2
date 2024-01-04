using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItemBehavior : MonoBehaviour
{
    [SerializeField] public string ItemName;
    private InventoryManage inventoryBox;

    // Start is called before the first frame update
    void Start()
    {
        inventoryBox = GameObject.Find("Inventory").GetComponent<InventoryManage>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        inventoryBox.DisplayItem(ItemName);
        Destroy(gameObject);
    }
}
