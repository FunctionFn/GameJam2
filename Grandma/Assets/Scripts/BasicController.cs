using UnityEngine;
using System.Collections;

public class BasicController : MonoBehaviour {

	public float speed;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Movement

		if (Input.GetKey(KeyCode.W)){
			transform.Translate(Vector3.up * (speed), Space.World);
		}
		if (Input.GetKey(KeyCode.A)){
			transform.Translate(Vector3.left * (speed), Space.World);
		}
		if (Input.GetKey(KeyCode.S)){
			transform.Translate(Vector3.down * (speed ), Space.World);
		}
		if (Input.GetKey(KeyCode.D)){
			transform.Translate(Vector3.right * (speed), Space.World);
		}


	}
}
