using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOff : MonoBehaviour {

    public AudioSource JackSong;

    private void OnTriggerEnter(Collider other)
    {
        JackSong.Stop();
    }
}
