using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningEvent : MonoBehaviour {

	Animator anim;

	public AudioSource doorAudio;

	void Start ()
	{
		anim = GetComponent<Animator>();
	}

	public void Init ()
	{
		StartCoroutine(InitRoutine());
	}

	IEnumerator InitRoutine ()
	{
		yield return new WaitForSeconds(1f);
		anim.SetTrigger("Init");
		doorAudio.Play();
	}
}
