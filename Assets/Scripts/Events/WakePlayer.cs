using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakePlayer : MonoBehaviour {

	bool canWakePlayer;

	void Update ()
	{
	  if (Input.anyKey && canWakePlayer)
		{
			GameObject.FindWithTag("Player").GetComponent<Animator>().SetTrigger("Wake");
			Destroy(this)
;			print("waking player");
		}
  }

	public void InitCanWakePlayer ()
	{
		canWakePlayer = true;
	}
}
