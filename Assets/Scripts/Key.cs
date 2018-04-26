using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : InventoryItemBase{

    public override string Name
    {
        get
        {
            return "Key";
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
        Items.GotKey = true;
    }
}
