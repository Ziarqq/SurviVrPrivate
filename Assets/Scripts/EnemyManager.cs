using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public GameObject Enemy;

    int Health = 100;

    void Update()
    {
        if(Health <= 0)
        {
            Enemy.SetActive(false);
            //ADD DEATH ANIMATION HERE 
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Weapon"))
        {
            Health -= 25;
        }
    }



}
