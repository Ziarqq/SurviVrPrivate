using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCardOpen : MonoBehaviour {

    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject CardText;
    public GameObject TheDoor;
    public GameObject ExtraCrosshair;
    public AudioSource Sound;
    public Animation anim;
    private bool GotCards;

    void Update()
    {
        anim = TheDoor.GetComponent<Animation>();
        Distance = PlayerCasting.DistanceFromTarget;
        GotCards = Items.Card1 && Items.Card2 && Items.Card3 && Items.Card4;
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
            CardText.SetActive(false);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (Distance <= 2 && GotCards)
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
                CardText.SetActive(true);
            }
        }

    }
    void OnMouseExit()
    {
        ExtraCrosshair.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        CardText.SetActive(false);
    }
    IEnumerator DoorClose()
    {
        yield return new WaitForSeconds(10);
        anim.Play("DoorCloseAnim");
        Sound.Play();
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
