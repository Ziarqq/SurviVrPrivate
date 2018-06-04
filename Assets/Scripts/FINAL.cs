using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FINAL : MonoBehaviour {

    public GameObject Car;
    public GameObject text;
    public static bool MadeIt = true;
    public GameObject FinishTrigger;
    private Text count;

    private void Start()
    {
        count = text.GetComponent<Text>();
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Counter());
        FinishTrigger.SetActive(true);
    }

    IEnumerator Counter()
    {
        yield return new WaitForSeconds(7f);
        text.SetActive(true);
        count.text = "10";
        yield return new WaitForSeconds(1f);
        count.text = "9";
        yield return new WaitForSeconds(1f);
        count.text = "8";
        yield return new WaitForSeconds(1f);
        count.text = "7";
        yield return new WaitForSeconds(1f);
        count.text = "6";
        yield return new WaitForSeconds(1f);
        count.text = "5";
        yield return new WaitForSeconds(1f);
        count.text = "4";
        yield return new WaitForSeconds(1f);
        count.text = "3";
        yield return new WaitForSeconds(1f);
        count.text = "2";
        yield return new WaitForSeconds(1f);
        count.text = "1";
        yield return new WaitForSeconds(1f);
        count.text = "THE CAR IS GONE...";
        MadeIt = false;




    }
}
