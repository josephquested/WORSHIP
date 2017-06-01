using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInit : MonoBehaviour {

	public GameObject playerPrefab;

	public void WakePlayer ()
	{
		GetComponent<Animator>().SetTrigger("Wake");
	}

	public void InitPlayer ()
	{
		Instantiate(playerPrefab, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
