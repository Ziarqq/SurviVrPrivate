using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class PinReal : MonoBehaviour {

    public InputField inputfield;
    public Animator anim;
    public GameObject ThePlayer;
    public GameObject trigger;
    public GameObject Wall;

    public void Text(string guess)
    {
        inputfield.text = "";
        if (guess == "1914")
        {
            anim.SetTrigger("Doors");
            Wall.SetActive(false);
            ThePlayer.GetComponent<FirstPersonController>().enabled = true;
            trigger.GetComponent<Collider>().enabled = false;
            gameObject.SetActive(false);

        }
        else
        {
            ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        }
    }
}
