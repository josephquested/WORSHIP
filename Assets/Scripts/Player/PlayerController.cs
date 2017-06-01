using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		movement = GetComponent<PlayerMovement>();
	}

	// MOVEMENT //

	PlayerMovement movement;

	public void ReceiveMovement (float horizontal, float vertical)
	{
		movement.ReceiveMovement(horizontal, vertical);
	}
}
