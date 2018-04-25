using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : InventoryItemBase {

    public override string Name
    {
        get
        {
            return "Knife";
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

    }
}
