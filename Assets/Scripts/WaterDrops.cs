using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDrops : MonoBehaviour
{
    public AudioSource Water;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Water.Play();
        }
    }
}