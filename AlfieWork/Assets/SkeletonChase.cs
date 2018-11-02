using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonChase : MonoBehaviour {

    //private Transform target = null;
    //public float minRange;
    public bool inRange;

	// Use this for initialization
	void Start () {

       
	}
	
	// Update is called once per frame
	void Update () {
		/*
        if(target == null)
        {
            return;
        }
        transform.LookAt(target);
        float distance = Vector3.Distance(target.transform.position, transform.position);
        bool tooClose = distance < minRange;
        Vector3 direction = tooClose ? Vector3.back : Vector3.forward;
        transform.Translate(direction * Time.deltaTime);
        */

	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            inRange = false;
        }
    }
}
