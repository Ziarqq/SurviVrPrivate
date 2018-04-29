using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffMusic : MonoBehaviour {


    public GameObject MusicOn;
    public GameObject MusicOff;

    private void Update()
    {
        if(!MusicOn.activeSelf)
        {
            MusicOff.SetActive(true);
        }
    }

}
