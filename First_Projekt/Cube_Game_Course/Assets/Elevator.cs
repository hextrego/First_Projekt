﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {

    public GameObject elevator;
    //public Transform target;
    //public float speed;
    

	
	private void onTriggerStay()
    {
        elevator.transform.position += elevator.transform.up * Time.deltaTime;
    }
}
