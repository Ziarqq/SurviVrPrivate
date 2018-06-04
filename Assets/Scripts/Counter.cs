using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {
    public GameObject counter;
    public BoxCollider col;

    private void OnTriggerEnter(Collider other)
    {
        counter.SetActive(true);
        Items.Cards += 1;
        col.enabled = false;
        
    }
}
