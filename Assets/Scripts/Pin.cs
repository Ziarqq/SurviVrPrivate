using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pin : MonoBehaviour {

    public GameObject inputfield;

    private void OnTriggerEnter(Collider other)
    {
        inputfield.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        inputfield.SetActive(false);
    }
}
