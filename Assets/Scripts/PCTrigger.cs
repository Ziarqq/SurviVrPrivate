using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCTrigger : MonoBehaviour {

    public GameObject text;
    public static bool ScreensOn = false;
    public Collider FirstCamera;
    public Collider SecondCamera;
    public Collider FinalCamera;
    public GameObject First;
    public GameObject Second;
    public GameObject Final;

    private void OnTriggerEnter(Collider other)
    {
        text.SetActive(true);
        FirstCamera.enabled = true;
        SecondCamera.enabled = true;
        FinalCamera.enabled = true;
        First.SetActive(true);
        Second.SetActive(true);
        Final.SetActive(true);
        ScreensOn = true;


    }
    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
    }
}
