using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upwardForce = 600f;
    public Collision collisionInfo = new Collision();
    void Start () {
        

    }
	
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        transform.rotation = Quaternion.Euler(0, 0, 0);     // doesn't rotate

        if (rb.position.y > 2)
        {
            
            rb.mass = 3;
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);     // doesn't rotate
            rb.drag = 0;
            rb.mass = 1;
        }

        

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime ,0,0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector3(0, upwardForce * Time.deltaTime, 0), ForceMode.Impulse);
        }
    }
  

}
