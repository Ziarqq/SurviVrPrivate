using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {

    public Transform player;
    public Animator anim;

	void Start () {
        anim = GetComponent<Animator>();
	}
	
	void Update () {
        Vector3 direction = player.position - this.transform.position;

        if (Vector3.Distance(player.position,this.transform.position) < 8)
        {
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            anim.SetBool("isIddle", false);
            if(direction.magnitude > 3)
            {
                this.transform.Translate(0, 0, 0.1f);
                anim.SetBool("isWalking", true);
                anim.SetBool("isAttacking", false);
            }
            else
            {
                anim.SetBool("isAttacking", true);
                anim.SetBool("isWalking", false);
            }
        }
        else
        {
            anim.SetBool("isIddle", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", false);
        }
	}
}
