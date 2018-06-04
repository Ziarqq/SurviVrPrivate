using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour {
    public static bool GotKey;
    public static int Meds;
    public static bool Card1;
    public static bool Card2;
    public static bool Card3;
    public static bool Card4;
    public static int Cards = 0;
    public Text counter;

    private void Update()
    {
        counter.text = "Cards: " + Cards + "/4";
    }
}
