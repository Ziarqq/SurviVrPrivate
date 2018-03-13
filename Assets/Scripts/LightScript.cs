using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour {

    public int LightMode;
    public GameObject LampLight;

	void Update () {
		if (LightMode == 0)
        {
            StartCoroutine(AnimateLight());
        }
	}

    IEnumerator AnimateLight ()
    {
        LightMode = Random.Range(1, 3);
        if (LightMode == 1)
        {
            LampLight.GetComponent<Animation>().Play("BrokenLight1");
        }
        if (LightMode == 2)
        {
            LampLight.GetComponent<Animation>().Play("BrokenLight2");
        }
        yield return new WaitForSeconds(0.99f);
        LightMode = 0;
    }
}
