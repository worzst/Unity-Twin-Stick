using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class CameraPan : MonoBehaviour {

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		print ("RHorizontal " + CrossPlatformInputManager.GetAxis("RHorizontal"));
		print ("RVertical " + CrossPlatformInputManager.GetAxis("RVertical"));
	}

	void LateUpdate() {
		transform.LookAt(player.transform);
	}
}
