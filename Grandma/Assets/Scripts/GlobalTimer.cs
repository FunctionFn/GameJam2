using UnityEngine;
using System.Collections;

public class GlobalTimer : MonoBehaviour {


	float timer;
	// Use this for initialization
	void Start () {
		timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.fixedDeltaTime;
		//Debug.Log (timer);

		if (timer >= 60) {
			timer=0;
				}
	}
}
