using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotBullet : MonoBehaviour {
    public float bulletSpeed = 10;
    public Rigidbody bulletObjekt;
    public Transform barrelEnd;
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
        Rigidbody bulletClone;
            bulletClone = Instantiate(bulletObjekt, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
        bulletClone.AddForce(barrelEnd.forward * bulletSpeed);
    }
}
