﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemClickHandler : MonoBehaviour {

    public Inventory _Inventory;

    public KeyCode _Key;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    void Update()
    {
        if (Input.GetKeyDown(_Key))
        {
            FadeToColor(_button.colors.pressedColor);
            //Click the button
            _button.onClick.Invoke();
        }
        else if(Input.GetKeyUp(_Key))
        {
            FadeToColor(_button.colors.normalColor);
        }
    }

    void FadeToColor(Color color)
    {
        Graphic graphic = GetComponent<Graphic>();
        graphic.CrossFadeColor(color, _button.colors.fadeDuration, true, true);
    }

    private IInventoryItem AttachedItem
    {
        get
        {
            ItemDragHandler dragHandler =
            gameObject.transform.GetChild(0).Find("ItemImage").GetComponent<ItemDragHandler>();
            return dragHandler.Item;
        }
    }

    public void OnItemClicked()
    {

        IInventoryItem item = AttachedItem;

        if(item != null)
        {
            _Inventory.UseItem(item);

            item.OnUse();
        }
    }
}
 