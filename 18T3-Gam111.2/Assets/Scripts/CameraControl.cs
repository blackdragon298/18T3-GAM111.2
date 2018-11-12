using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
	GameObject player;

	// Use this for initialization
	void Start()
	{
		player = GameObject.Find("Player");
	}

	// Update is called once per frame
	void Update()
	{
		Vector3 lookPos = player.transform.position;
		lookPos.y += 0.5f;
		this.transform.LookAt(lookPos);
		if (Input.GetKeyDown("x"))
		{
			print(Vector3.Distance(player.transform.position, this.transform.position));
		}

	}

	// Change PoV between 10 and 50 based on player distance
	// Close distance : 6
	// Far Distance : 28

}
