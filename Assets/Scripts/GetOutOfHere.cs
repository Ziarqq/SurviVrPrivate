using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GetOutOfHere : MonoBehaviour {

    public GameObject ThePlayer;
    public GameObject Message;
    public GameObject Inventory;
    public GameObject Slider;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(GetOut());
    }
    IEnumerator GetOut()
    {
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        Inventory.SetActive(false);
        Slider.SetActive(false);
        Message.SetActive(true);
        yield return new WaitForSeconds(3f);
        Message.SetActive(false);
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        gameObject.SetActive(false);
        Slider.SetActive(true);
        Inventory.SetActive(true);
    }
}
