﻿using System.Collections;
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
		lookPos.y += 1f;
		this.transform.LookAt(lookPos);
	}
}