using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBear : MonoBehaviour {

    public GameObject TeddyText;

    private void OnTriggerEnter(Collider other)
    {
        TeddyText.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        TeddyText.SetActive(false);
    }
}
