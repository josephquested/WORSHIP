using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakePlayer : MonoBehaviour {

	bool canWakePlayer;

	void Update ()
	{
	  if (Input.anyKeyDown && canWakePlayer)
		{
			print("wake");
			GameObject.FindWithTag("Player").GetComponent<Animator>().SetTrigger("Wake");
			Destroy(this);
			print("waking player");
		}
  }

	public void InitCanWakePlayer ()
	{
		print("player can wake");
		canWakePlayer = true;
	}
}
