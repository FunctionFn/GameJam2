using UnityEngine;
using System.Collections;

public class ButtonBottom : ButtonBase {

	private static ButtonBottom _inst;
	public static ButtonBottom Inst { get { return _inst; } }
	
	void Awake()
	{
		
		_inst = this;
		
	}
	public void OnMouseDown() {
		Debug.Log ("click");
		

		ButtonTop.Inst.selfDestruct ();
		selfDestruct ();

	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
