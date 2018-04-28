using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinReal : MonoBehaviour {

    public InputField inputfield;
    public Animator anim;

    public void Text(string guess)
    {
        inputfield.text = "";
        if(guess == "1914")
        {
            Debug.Log("You geessesd it");
            anim.SetTrigger("Doors");
            gameObject.SetActive(false);

        }
        else
        {
            Debug.Log("nope");
        }
    }
}
