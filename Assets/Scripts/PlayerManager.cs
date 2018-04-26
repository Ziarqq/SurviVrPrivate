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
    public HUD hud;
    public GameObject Hand;
    public Animator anim;

    int Health = 100;
    public Slider HealthBar;
    void Start()
    {
        inventory.ItemUsed += Inventory_ItemUsed;
        inventory.ItemRemoved += Inventory_ItemRemoved;
    }

    private void Inventory_ItemRemoved(object sender, InventoryEventArgs e)
    {
        IInventoryItem item = e.Item;

        GameObject goItem = (item as MonoBehaviour).gameObject;
        goItem.SetActive(true);

        goItem.transform.parent = null;
    }

    private void Inventory_ItemUsed(object sender, InventoryEventArgs e)
    {
        IInventoryItem item = e.Item;
        // Do something with the item
        GameObject goItem = (item as MonoBehaviour).gameObject;
        goItem.SetActive(true);

        goItem.transform.parent = Hand.transform;

    }

    void Update()
    {
        if(mItemToPickup != null && Input.GetKeyDown(KeyCode.E))
        {
            inventory.AddItem(mItemToPickup);
            anim.SetTrigger("PickUp");
            mItemToPickup.OnPickup();
            hud.CloseMessagePanel();
            
        }
        if (Health <= 0)
        {
            StartCoroutine(Death());
        }
    }
    private IInventoryItem mItemToPickup = null;

    void OnTriggerEnter(Collider other)
    { 
        if(other.CompareTag("Enemy"))
        {
            Health -= 10;
            HealthBar.value -= 0.1f;
        }
        IInventoryItem item = other.GetComponent<Collider>().GetComponent<IInventoryItem>();
        if (item != null)
        {
            mItemToPickup = item;
            hud.OpenMessagePanel("");
        }
    }
    void OnTriggerExit(Collider other)
    {
        IInventoryItem item = other.GetComponent<Collider>().GetComponent<IInventoryItem>();
        if (item != null)
        {
            hud.CloseMessagePanel();
            mItemToPickup = null;
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

}
