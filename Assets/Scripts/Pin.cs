using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class Pin : MonoBehaviour {

    public GameObject inputfield;
    public GameObject ThePlayer;

    private void OnTriggerEnter(Collider other)
    {
        inputfield.SetActive(true);
        inputfield.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Enter password:";
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        Cursor.visible = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inputfield.SetActive(false);
        Cursor.visible = false;
    }
}
