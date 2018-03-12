using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Opening : MonoBehaviour {

    public GameObject ThePlayer;
    public GameObject FadeScreen;
    public GameObject TextBox;

	void Start () {
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
	}

    IEnumerator ScenePlayer ()
    {
        yield return new WaitForSeconds(0.5f);
        TextBox.GetComponent<Text>().text = "Where am I...";
        yield return new WaitForSeconds(2f);
        TextBox.GetComponent<Text>().text = "";
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;

        
    }
	

}
