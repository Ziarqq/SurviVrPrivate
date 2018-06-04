using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card2 : InventoryItemBase {
    public override string Name
    {
        get
        {
            return "Card2";
        }
    }

    public override void OnUse()
    {
        //TODO: Do something with the object... 
        base.OnUse();
    }

    public override void OnPickup()
    {
        base.OnPickup();
        Items.Card2 = true;
    }
}
