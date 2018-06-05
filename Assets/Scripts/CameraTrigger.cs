using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {

    public GameObject Trigger;

    private void OnTriggerEnter(Collider other)
    {
        Trigger.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        Trigger.SetActive(false);
    }
}
