﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {

        anim = gameObject.GetComponent<Animator>();


    }
	
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("Swing", true);
        }


    }

	

}
