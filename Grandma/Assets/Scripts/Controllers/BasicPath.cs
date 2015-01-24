using UnityEngine;
using System.Collections;

public class BasicPath : MonoBehaviour {




	public GameObject bedroom;
	public GameObject garden;
	public GameObject hospital;
	public GameObject kitchen;

	public int behaviorState;
	public float travelTime;
	/*
	 * Behavior States:
	 * 0: Neutral
	 * 1: Hungry
	 * 2: Sick
	 * 3: Cramped
	 * 4: Sleepy
	 * 5: Moving
	 */

	// Use this for initialization
	void Start () {
	
		behaviorState = 0;

	}
	
	// Update is called once per frame
	void Update () {

		if (behaviorState == 0) {
			changeState ();
				}

		if (behaviorState != 0 && behaviorState != 5) {
			beginMovement();
				}
		
	}

	void changeState()
	{
		behaviorState = Random.Range(0,5);
	}

	void beginMovement()
	{

		if (behaviorState == 1)
		{
			iTween.MoveTo(gameObject, iTween.Hash("position", kitchen.transform.position,
			                         "time", travelTime,
			                         "easetype", iTween.EaseType.easeInOutCubic,
			                         "oncomplete", "changeState",
			                         "oncompletetarget", gameObject));
		}
		if (behaviorState == 2)
		{
			iTween.MoveTo(gameObject, iTween.Hash("position", hospital.transform.position,
			                   "time", travelTime,
			                   "easetype", iTween.EaseType.easeInOutCubic,
			                   "oncomplete", "changeState",
			                   "oncompletetarget", gameObject));
		}

		if (behaviorState == 3)
		{
			iTween.MoveTo(gameObject, iTween.Hash("position", garden.transform.position,
		                   "time", travelTime,
		                   "easetype", iTween.EaseType.easeInOutCubic,
		                   "oncomplete", "changeState",
		                   "oncompletetarget", gameObject));
		}
		
		if (behaviorState == 4)
		{
			iTween.MoveTo(gameObject, iTween.Hash("position", bedroom.transform.position,
			                         "time", travelTime,
			                         "easetype", iTween.EaseType.easeInOutCubic,
			                         "oncomplete", "changeState",
			                         "oncompletetarget", gameObject));
		}
		




	}


}


