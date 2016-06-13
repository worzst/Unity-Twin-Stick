using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool recording = true;

	void Start() {
		//PlayerPrefsManager.SetLevelUnlock(1);
		//print(PlayerPrefsManager.GetLevelUnlock(1));
		//print(PlayerPrefsManager.GetLevelUnlock(2));
	}

	// Update is called once per frame
	void Update () {
		if(CrossPlatformInputManager.GetButton("Fire1")) {
			recording = false;
		} else {
			recording = true;
		}
	}
}
