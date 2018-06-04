using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class FINISH : MonoBehaviour {
    public Text text;
    public GameObject FinalMessage;
    public GameObject Player;
    public GameObject Credits;
    public GameObject YouFailed;

    private void OnTriggerEnter(Collider other)
    {
        if (FINAL.MadeIt)
        {
            text.enabled = false;
            FinalMessage.SetActive(true);
            StartCoroutine(Finish());
        }
        if(!FINAL.MadeIt)
        {
            text.enabled = false;
            StartCoroutine(NotFinished());
        }
    }

    IEnumerator Finish()
    {
        yield return new WaitForSeconds(5f);
        Player.GetComponent<FirstPersonController>().enabled = false;
        FinalMessage.SetActive(false);
        Credits.SetActive(true);
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("main-menu");

    }

    IEnumerator NotFinished()
    {
        Player.GetComponent<FirstPersonController>().enabled = false;
        YouFailed.SetActive(true);
        yield return new WaitForSeconds(6f);
        YouFailed.SetActive(false);
        Credits.SetActive(true);
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("main-menu");

    }

}
