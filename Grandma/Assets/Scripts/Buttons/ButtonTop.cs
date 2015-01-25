using UnityEngine;
using System.Collections;

public class ButtonTop : ButtonBase {

	private static ButtonTop _inst;
	public static ButtonTop Inst { get { return _inst; } }


	public GameObject bottomButton;

	void Awake()
	{
		
		_inst = this;
		
	}

	public void OnMouseDown() {
		Debug.Log ("click");

		ButtonBottom.Inst.selfDestruct ();


		selfDestruct ();

		
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
