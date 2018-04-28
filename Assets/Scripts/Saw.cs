using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Saw : MonoBehaviour {

    public GameObject MessagePanel;
    public Text txt; 

    private void OnTriggerEnter(Collider other)
    {
        MessagePanel.SetActive(true);
        txt.text = "- You can't pick this up -";
    }
    private void OnTriggerExit(Collider other)
    {
        MessagePanel.SetActive(false);
    }
}
