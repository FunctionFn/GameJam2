using UnityEngine;
using System.Collections;

public class ElderlyBase : MonoBehaviour {




	public GameObject bedroom;
	public GameObject garden;
	public GameObject hospital;
	public GameObject kitchen;
	public GameObject clinic;
	public GameObject rec;

	public int behaviorState;
	public float travelTime;
	public float xRand;
	public float yRand;

	public Vector3 neutralLoc;
	public Vector3[] pathbn;

	protected float waitTime;

	public NPC npc;
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
		//beginMovement ();
	}
	
	// Update is called once per frame
	 void Update () {
		npc.Update ();
		if (npc.isWalking) {
			if (npc.curr_state == GoToDen_State.getInstance ()) {
				MoveTo(rec.transform.position);
			}
			else if(npc.curr_state == GoToGarden_State.getInstance()) {
				MoveTo(garden.transform.position);
			}
			else if(npc.curr_state == GoToInfirmary_State.getInstance()){
				MoveTo(hospital.transform.position);
			}
			else if(npc.curr_state == GoToKitchen_State.getInstance()){
				MoveTo(kitchen.transform.position);
			}
			else if(npc.curr_state == GoToPT_State.getInstance()){
				MoveTo(clinic.transform.position);
			}
		}
		
	}

	void changeState()
	{
		Debug.Log ("changeState()");
		behaviorState = Random.Range(0,6);
	}

	public void MoveTo(Vector3 target)
	{

		iTween.MoveTo(gameObject, iTween.Hash ("position", target,
		                                      "easetype", iTween.EaseType.linear,
		                                      "time", travelTime,
		                                      //"delay", waitTime
		                                       "oncomplete", "OnStop"));
		                                      //"oncompletetarget", gameObject


	}

	private void OnStop()
	{
		npc.isWalking = false;
	}


	//Obsolete/testing movement

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
		//changeState ();
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
		if (behaviorState == 4) 
		{
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


