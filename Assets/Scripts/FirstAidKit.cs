using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAidKit : InventoryItemBase {

    public override string Name
    {
        get
        {
            return "MedKit";
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
        Items.Meds += 1;    
    }

}
