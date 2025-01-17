﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Opening : MonoBehaviour {

    public GameObject ThePlayer;
    public GameObject FadeScreen;
    public GameObject TextBox;
    public GameObject HUD;
    public GameObject slider;

	void Start () {
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
        HUD.SetActive(false);
        slider.SetActive(false);
	}

    IEnumerator ScenePlayer ()
    {
        yield return new WaitForSeconds(0.5f);
        TextBox.GetComponent<Text>().text = "Where am I...";
        yield return new WaitForSeconds(2f);
        TextBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1f);
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        HUD.SetActive(true);
        slider.SetActive(true);

        
    }
	

}
