using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class LastRooom : MonoBehaviour {

    public GameObject ThePlayer;
    public GameObject MessageON;
    public GameObject Inventory;
    public GameObject Slider;
    public GameObject MessageOff;

    private void OnTriggerEnter(Collider other)
    {
        if(PCTrigger.ScreensOn)
        {
            StartCoroutine(GetOut());
        }
        if(!PCTrigger.ScreensOn)
        {
            MessageOff.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        MessageOff.SetActive(false);
    }
    IEnumerator GetOut()
    {
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        Inventory.SetActive(false);
        Slider.SetActive(false);
        MessageON.SetActive(true);
        yield return new WaitForSeconds(1.7f);
        MessageON.SetActive(false);
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        gameObject.SetActive(false);
        Slider.SetActive(true);
        Inventory.SetActive(true);
    }
    }

