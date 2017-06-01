using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInit : MonoBehaviour {

	public GameObject playerPrefab;
	public OpeningEvent openingEvent;

	public void WakePlayer ()
	{
		GetComponent<Animator>().SetTrigger("Wake");
	}

	public void InitPlayer ()
	{
		Instantiate(playerPrefab, transform.position, transform.rotation);
		openingEvent.Init();
		Destroy(gameObject);
	}
}
