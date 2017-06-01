using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// SYSTEM //

	Rigidbody rb;
	Animator anim;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		anim = GetComponent<Animator>();
	}

	// MOVEMENT //

	public float speed;

	public void ReceiveMovement (float horizontal, float vertical)
	{
		Vector3 movement = new Vector3(horizontal, 0, vertical);
		if (horizontal != 0 && vertical != 0) { movement = movement * 0.75f; }
		AnimateMovement(horizontal != 0 || vertical != 0);
		Move(movement);
	}

	void Move (Vector3 movement)
	{
		rb.AddForce(movement * speed);
	}

	void AnimateMovement (bool isMoving)
	{
		anim.SetBool("Moving", isMoving);
	}
}
