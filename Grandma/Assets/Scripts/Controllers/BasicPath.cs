using UnityEngine;
using System.Collections;

public class BasicPath : MonoBehaviour {




	public GameObject bedroom;
	public GameObject garden;
	public GameObject hospital;
	public GameObject kitchen;
	public GameObject clinic;
	public GameObject rec;

	public int behaviorState;
	public float travelTime;

	public Vector3 neutralLoc;
	public Vector3[] pathbn;

	public float waitTime;
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

		pathbn = new [] { bedroom.transform.position, neutralLoc};



		behaviorState = 0;
		beginMovement ();
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void changeState()
	{
		Debug.Log ("changeState()");
		behaviorState = Random.Range(0,6);
	}

	void beginMovement()
	{
		Debug.Log ("beginMovement()");
		behaviorState = 5;

		iTween.MoveTo(gameObject, iTween.Hash ("path", getPath(),
		                                       "easetype", iTween.EaseType.linear,
		                                       "time", travelTime,
		                                       "delay", waitTime,
		                                       "oncomplete", "beginMovement",
		                                       "oncompletetarget", gameObject));

		/*
		if (behaviorState == 1)
		{
			iTween.MoveTo(gameObject, iTween.Hash ("path", bedroom.transform.position,
			                                       "easetype", iTween.EaseType.linear,
			                                       "time", travelTime));
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
		
		*/



	}

	Vector3[] getPath()
	{
		changeState ();
		Debug.Log ("getPath()");
		Vector3[] path = new [] { 
			gameObject.transform.position, 
			neutralLoc, 
			getDestination().transform.position };
		return path;
	}
	
	GameObject getDestination(){

		Debug.Log ("getDestination()");

		if (behaviorState == 1)
		{
			return kitchen;
		}
		if (behaviorState == 2)
		{
			return hospital;
		}
		if (behaviorState == 3)
		{
			return garden;
		}
		if (behaviorState == 4) {
			return clinic;

				}
		if (behaviorState == 5)
		{
			return rec;
		}
		else
		{
			return bedroom;
		}

	}

}


