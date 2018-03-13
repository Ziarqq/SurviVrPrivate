using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

    int Health = 100;
    public Slider HealthBar;

    void Update()
    {
        if (Health <= 0)
        {
            //You DIED
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Health -= 100;
            HealthBar.value -= 0.1f;
        }
    }
}
