using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SkeletonCollision : MonoBehaviour {

    Animator animator;
    
    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    }


    void OnTriggerEnter(Collider other)
    {

         if (other.gameObject.tag == "Player")
        {
        
            animator.SetBool("hit", true);
        }
    }
}
