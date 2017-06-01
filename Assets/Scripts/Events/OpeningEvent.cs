using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningEvent : MonoBehaviour {

	Animator anim;

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public IEnumerator InitRoutine ()
	{
		print("starting");
		yield return new WaitForSeconds(3f);
		print("end");
	}
}
