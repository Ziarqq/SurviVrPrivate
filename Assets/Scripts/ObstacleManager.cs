using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour {

    public GameObject obstacle;

    int Health = 100;

    void Update()
    {
        if (Health <= 0)
        {
            obstacle.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Weapon"))
        {
            Health -= 50;
        }
    }
}
