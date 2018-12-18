using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorscript : MonoBehaviour {

    public GameObject elevator;
    //public Transform target;
    //public float speed;



    private void OnTriggerStay()
    {
        elevator.transform.position += elevator.transform.up * Time.deltaTime;
        Debug.Log("Eevator");
    }
}
