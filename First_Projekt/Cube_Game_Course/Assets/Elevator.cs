using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {

    public GameObject player;
    public float x = 0, y = 2, z  =0.42F;

    // The target marker.
    public Transform target;

    // Speed in units per sec.
    public float speed;
    // Use this for initialization

    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        
            // The step size is equal to speed times frame time.
            float step = speed * Time.deltaTime;

            // Move our position a step closer to the target.
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            //player.transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
