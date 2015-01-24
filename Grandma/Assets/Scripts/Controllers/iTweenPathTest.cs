using UnityEngine;
using System.Collections;

public class iTweenPathTest : MonoBehaviour {


	public GameObject bedroom;
	public GameObject garden;
	public GameObject hospital;
	public GameObject kitchen;

	public float moveTime;
	
	public Vector3 neutralLoc;

	public Vector3[] pathbg; 

	// Use this for initialization
	void Start () {
		pathbg = new [] { bedroom.transform.position, neutralLoc, garden.transform.position};
		iTween.PutOnPath (gameObject, pathbg, 0.3f);

		followPath();

	}
	
	// Update is called once per frame
	void Update () {




		}
	void followPath()
	{
		Debug.Log ("MoveTo");
		iTween.MoveTo(gameObject, iTween.Hash ("path", pathbg,
		                                       "easetype", iTween.EaseType.linear,
		                                       "time", moveTime));

	}
}
