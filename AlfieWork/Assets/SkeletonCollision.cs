using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SkeletonCollision : MonoBehaviour {

    float delay = 10.0f;
    public Rigidbody rb;
    Animator animator;
    
    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }


    void OnTriggerEnter(Collider other)
    {

         if (other.gameObject.tag == "Sword")
        {
        
            animator.SetBool("hit", true);
            rb.isKinematic = true;
            rb.detectCollisions = false;
            Destroy(gameObject, delay);
        }
    }

    /*void DisableRagdoll()
    {

        rb.isKinematic = true;
        rb.detectCollisions = false;

    }
    */
   
}
