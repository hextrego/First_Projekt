using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;

    public Joystick joystick;
    public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	
	// Update is called once per frame
	void Update () {

		horizontalMove = joystick.Horizontal * runSpeed;

        float verticalMove = joystick.Vertical;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (verticalMove >= .5f)
		{
			jump = true;
		}

		if (verticalMove <= -.5f)
		{
			crouch = true;
		} else 
		{
			crouch = false;
		}

	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}
