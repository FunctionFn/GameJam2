using UnityEngine;
using System.Collections;

public class SpeechBubbleBase : MonoBehaviour {

	public float appearanceTime;

	float timer;
	void Start () {
		renderer.enabled = false;
	}


	// Update is called once per frame
	void Update () {
		if (renderer.enabled) {
			timer+=Time.fixedDeltaTime;
				}

		if (timer >= appearanceTime) {
			renderer.enabled = false;
			timer = 0;
				}
	}

	public void Appear(){
		Debug.Log ("*Click*");
		renderer.enabled = true;
		
	}




}
