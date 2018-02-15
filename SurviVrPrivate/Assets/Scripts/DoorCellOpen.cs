using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCellOpen : MonoBehaviour {

    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheDoor;
    public GameObject ExtraCrosshair;
    public AudioSource Sound;
    public Animation anim;

	void Update ()
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
        }
        if (Input.GetButtonDown("Action"))
        {
            if (Distance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                anim.Play("DoorOpenAnim");
                Sound.Play();
                StartCoroutine(DoorClose());
            }
        }

    }
    void OnMouseExit()
    {
        ExtraCrosshair.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
    IEnumerator DoorClose()
    {
        yield return new WaitForSeconds(5);
        anim.Play("DoorCloseAnim");
        Sound.Play();
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
