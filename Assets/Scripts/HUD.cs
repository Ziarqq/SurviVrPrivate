using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Inventory Inventory;

    void Start()
    {
        Inventory.ItemAdded += InventoryScript_ItemAdded; 
    }

    void InventoryScript_ItemAdded(object sender,InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach(Transform Border in inventoryPanel)
        {
            //Border ... Image
            Image image = Border.GetChild(0).GetChild(0).GetComponent<Image>();

            //We found the empty slot
            if(!image.enabled)
            {
                image.enabled = true;
                image.sprite = e.Item.Image;

                //TODO: Store a referenece to the item

                break;
            }
        }
       
    }
}
