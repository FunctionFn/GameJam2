using UnityEngine;
using System.Collections;

public class PlaceholderSpriteController : MonoBehaviour {


	public float timer = 0f;

	public float directionDuration;

	public int direction;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.fixedDeltaTime;

		if (timer >= directionDuration) {
			direction = Random.Range(0,4);
			timer = 0;
		}

		if (direction == 0) {
			transform.Translate(Vector3.up * (speed), Space.World);


		}
		if (direction == 1) {
			transform.Translate(Vector3.down * (speed), Space.World);
			
			
		}
		if (direction == 2) {
			transform.Translate(Vector3.left * (speed), Space.World);
			
			
		}

		if (direction == 3) {
			transform.Translate(Vector3.right * (speed), Space.World);
			
			
		}


	}
}
