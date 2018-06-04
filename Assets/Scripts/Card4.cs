using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card4 : InventoryItemBase {

    public override string Name
    {
        get
        {
            return "Card4";
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
        Items.Card4 = true;
    }
}
