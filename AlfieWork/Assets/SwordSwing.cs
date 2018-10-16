using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour {

    Quaternion initpos;
    Quaternion destpos;
    private float timeCount = 0.0f;
    public float rotSpeed;

	// Use this for initialization
	void Start () {

      

}
	
	// Update is called once per frame
	void Update () {
        initpos = transform.rotation;
        destpos = GameObject.Find("EmptyRotate").transform.rotation;
        timeCount = Time.deltaTime * rotSpeed;

        if (Input.GetMouseButton(0))
        {
            transform.rotation = Quaternion.Slerp(initpos, destpos, timeCount);
            yield WaitForSeconds(1);
           
            transform.rotation = Quaternion.Slerp(destpos, initpos, timeCount);
            
        }
        

        


    }
}
