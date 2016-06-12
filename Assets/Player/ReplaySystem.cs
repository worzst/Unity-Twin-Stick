﻿using UnityEngine;
using System.Collections;

public class ReplaySystem : MonoBehaviour {

	private const int bufferFrames = 100;
	private MyKeyFrame[] keyFrames = new MyKeyFrame[bufferFrames];

	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Record();
	}

	void PlayBack() {
		rigidBody.isKinematic = true;
		int frame = Time.frameCount % bufferFrames;
		print("Reading Frame " + frame);
		transform.position = keyFrames[frame].position;
		transform.rotation = keyFrames[frame].rotation;
	}

	void Record() {
		rigidBody.isKinematic = false;
		int frame = Time.frameCount % bufferFrames;
		float time = Time.time;
		print("Writing frame " + frame);
		keyFrames[frame] = new MyKeyFrame(time, transform.position, transform.rotation);
	}
}

/// <summary>
/// A structure for storing time, position and rotation.
/// </summary>
public struct MyKeyFrame {

	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;

	public MyKeyFrame(float time, Vector3 pos, Quaternion rot) {
		frameTime = time;
		position = pos;
		rotation = rot;
	}
}