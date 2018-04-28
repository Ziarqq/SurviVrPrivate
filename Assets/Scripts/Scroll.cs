using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{

    public GameObject ScrollPanel;

    private void OnTriggerEnter(Collider other)
    {
        ScrollPanel.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        ScrollPanel.SetActive(false);
    }
}
       
