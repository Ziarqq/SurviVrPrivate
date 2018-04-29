using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareJack : MonoBehaviour {
    public AudioSource laught;
    public AudioSource JackSong;

    private void Start()
    {
        laught.volume = 0.4f;
    }

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Jumpscare());
    }

    IEnumerator Jumpscare()
    {
        yield return new WaitForSeconds(2f);
        laught.Play();
        yield return new WaitForSeconds(3f);
        JackSong.Play();
        gameObject.SetActive(false);
    }

}
