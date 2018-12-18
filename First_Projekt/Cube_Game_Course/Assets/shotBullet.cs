using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotBullet : MonoBehaviour {
    public float bulletSpeed = 10;
    public Rigidbody bullet;
    public GameObject bulletObj;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    


    void Fire()
    {
        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.velocity = bulletObj.transform.forward * bulletSpeed;
    }
}
