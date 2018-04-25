using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PickUpAxe: MonoBehaviour
{

    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject RealAxe;
    public GameObject FakeAxe;
    public GameObject ExtraCrosshair;


    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver(Collider hit)
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
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                RealAxe.SetActive(true);
                FakeAxe.SetActive(false);
            }
        }

    }
    void OnMouseExit()
    {
        ExtraCrosshair.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

}
