using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenKey : MonoBehaviour {


    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject KeyText;
    public GameObject TheDoor;
    public GameObject ExtraCrosshair;
    public AudioSource Sound;
    public Animation anim;

    void Update()
    {
        anim = TheDoor.GetComponent<Animation>();
        Distance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (Distance <= 2)
        {
            ExtraCrosshair.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Distance > 2)
        {
            ExtraCrosshair.SetActive(false);
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            KeyText.SetActive(false);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (Distance <= 2 && Items.GotKey)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                anim.Play("DoorOpenAnim");
                Sound.Play();
                StartCoroutine(DoorClose());
            }
            else
            {
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                KeyText.SetActive(true);
            }
        }

    }
    void OnMouseExit()
    {
        ExtraCrosshair.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        KeyText.SetActive(false);
    }
    IEnumerator DoorClose()
    {
        yield return new WaitForSeconds(10);
        anim.Play("DoorCloseAnim");
        Sound.Play();
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
