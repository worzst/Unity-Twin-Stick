﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class SelfieStick : MonoBehaviour {

	public float panSpeed = 10f;

	private GameObject player;
	private Vector3 armRotation;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		armRotation = transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		armRotation.y += CrossPlatformInputManager.GetAxis("RHorizontal") * panSpeed;
		armRotation.x += CrossPlatformInputManager.GetAxis("RVertical") * panSpeed;
		transform.position = player.transform.position;
		transform.rotation = Quaternion.Euler(armRotation);
	}
}
