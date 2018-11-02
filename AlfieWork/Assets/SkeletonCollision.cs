using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkeletonChase;


public class SkeletonCollision : MonoBehaviour {

    float delay = 10.0f;
    public Rigidbody rb;
    Animator animator;
    private GameObject target;
    public float minRange;
    bool skelMove;
    
    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindWithTag("Player");
        ChaseObject SkeletonChase = GetComponentInChildren<ChaseObject>();
    }


    void Update()
    {
        
        skelMove = SkeletonChase.inRange;
        if (skelMove == true)
        {
            transform.LookAt(target.transform);
            float distance = Vector3.Distance(target.transform.position, transform.position);
            bool tooClose = distance < minRange;
            Vector3 direction = tooClose ? Vector3.back : Vector3.forward;
            transform.Translate(direction * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {

         if (other.gameObject.tag == "Bullet")
        {
        
            animator.SetBool("hit", true);
            rb.isKinematic = true;
            rb.detectCollisions = false;
            Destroy(gameObject, delay);
        }
    }

   
   
}
