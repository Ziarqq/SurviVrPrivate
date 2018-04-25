using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Inventory Inventory;
    public GameObject MessagePanel;

    void Start()
    {
        Inventory.ItemAdded += InventoryScript_ItemAdded;
        Inventory.ItemRemoved += Inventory_ItemRemoved;
    }

    void InventoryScript_ItemAdded(object sender,InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach(Transform Border in inventoryPanel)
        {
            //Border ... Image
            Transform imageTransform = Border.GetChild(0).GetChild(0);
            Image image = imageTransform.GetComponent<Image>();
            ItemDragHandler itemDragHandler = imageTransform.GetComponent<ItemDragHandler>();

            //We found the empty slot
            if(!image.enabled)
            {
                image.enabled = true;
                image.sprite = e.Item.Image;

                //Store a referenece to the item
                itemDragHandler.Item = e.Item;

                break;
            }
        }
    }
    private void Inventory_ItemRemoved(object sender,InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach(Transform Border in inventoryPanel)
        {
            Transform imageTransform = Border.GetChild(0).GetChild(0);
            Image image = imageTransform.GetComponent<Image>();
            ItemDragHandler itemDragHandler = imageTransform.GetComponent<ItemDragHandler>();

            if(itemDragHandler.Item.Equals(e.Item))
            {
                image.enabled = false;
                image.sprite = null;
                itemDragHandler.Item = null;
                break;
            }
        }
    }
    public void OpenMessagePanel(string text) 
    {
        MessagePanel.SetActive(true);

        //TODO: set text when we will use this for other messages as well
    }
    public void CloseMessagePanel()
    {
        MessagePanel.SetActive(false);
    }
}
