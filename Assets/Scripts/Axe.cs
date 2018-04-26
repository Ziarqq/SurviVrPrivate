using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : InventoryItemBase
{
    public GameObject RealAxe;
    public override string Name
    {
        get
        {
            return "Axe";
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
        RealAxe.SetActive(true);
    }

}
