using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonBase : MonoBehaviour {


	public Text buttonTextObject;

	void Start () {
		buttonTextObject = GetComponent<Text>();
		selfDestruct ();
	}

	void Update () {
	
	}



	public void selfDestruct()
	{
		Debug.Log ("boom");
		gameObject.GetComponent<BoxCollider>().isTrigger = false;
		gameObject.renderer.enabled = false;
		buttonTextObject.text="";
	}

	public void FeedText(string buttonText)
	{
		buttonTextObject.text = buttonText;
		gameObject.GetComponent<BoxCollider>().isTrigger = true;
		gameObject.renderer.enabled = true;
	}

}
