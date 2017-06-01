using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakePlayer : MonoBehaviour {

	bool canWakePlayer;

	void Update ()
	{
	  if (Input.anyKeyDown && canWakePlayer)
		{
			GameObject.FindWithTag("Player").GetComponent<PlayerInit>().WakePlayer();
			Destroy(this);
		}
  }

	public void InitCanWakePlayer ()
	{
		canWakePlayer = true;
	}
}
