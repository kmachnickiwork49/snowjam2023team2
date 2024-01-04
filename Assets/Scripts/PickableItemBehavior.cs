using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItemBehavior : MonoBehaviour
{
    [SerializeField] public string ItemName;
    private InventoryManage inventoryBox;

    [SerializeField] private AudioSource audio;
    private int numPlayed = 0;
    [SerializeField] private int numActivations = 1;

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

        // New logic
        // Can press multiple times and play audio before sending to inventory
        if (numPlayed < numActivations && audio != null) {
            audio.Play();
        }
        numPlayed = numPlayed + 1;
        if (numPlayed >= numActivations) {
            inventoryBox.DisplayItem(ItemName);
            Destroy(gameObject);
        }
    }
}
