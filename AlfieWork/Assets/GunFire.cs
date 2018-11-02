using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {

    public Rigidbody bulletPrefab;
    public float speed = 6;
    public Transform Spawn;
    private GameObject player;
    
   // public Transform bulletSpawn;

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {

     

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
	}

    void Fire()
    {

        Vector3 mouse = Input.mousePosition;
        Vector3 mouseWorld = UnityEngine.Camera.main.ScreenToWorldPoint(new Vector3(
                                                            mouse.x - 20,
                                                            mouse.y - 250,
                                                            player.transform.position.y));
        Vector3 forward = mouseWorld - player.transform.position;


        var gameBullet = Instantiate(
            bulletPrefab,
            Spawn.position,
            Spawn.rotation);
            
          

        gameBullet.GetComponent<Rigidbody>().AddForce(forward.normalized * 2000f);

        //gameBullet.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

        Destroy(gameBullet, 6f);
        Destroy(gameBullet.gameObject, 6f);

    }
}
