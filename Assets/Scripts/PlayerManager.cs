using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerManager : MonoBehaviour {

    public GameObject ThePlayer;
    public GameObject DeathScene;
    public GameObject DeathText;
    public Inventory inventory;
    public GameObject PickupText;

    int Health = 100;
    public Slider HealthBar;

    void Update()
    {
        if (Health <= 0)
        {
            StartCoroutine(Death());
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Health -= 10;
            HealthBar.value -= 0.1f;
        }
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        IInventoryItem item = hit.collider.GetComponent<IInventoryItem>();
        if(item != null)
        {
            inventory.AddItem(item);
            StartCoroutine(PickUpText());
        }

    }


    IEnumerator Death()
    { 
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        DeathScene.SetActive(true);
        DeathText.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        DeathText.GetComponent<Text>().text = "YOU DIED";
        yield return new WaitForSeconds(5f);
        DeathText.GetComponent<Text>().text = "";
        SceneManager.LoadScene("main-menu");
    }
    IEnumerator PickUpText()
    {
        PickupText.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        PickupText.SetActive(false);
    }
}
