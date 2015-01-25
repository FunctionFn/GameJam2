using UnityEngine;
using System.Collections;

public class ElderlyGreen : ElderlyBase {
	
	private static ElderlyGreen _inst;
	public static ElderlyGreen Inst { get { return _inst; } }


	private NPC green;

	void Start()
	{
		green = new NPC ("Abe");
		green.thresholds = new Threshold(35, 64, 19, 88, 25, 75, 30, 66, 15, 78, 19, 88);
		//Debug.Log ("***********DONT IGnORE ME **********");
	}

	void Update()
	{
		green.Update ();

		//Debug.Log ("after update**********");
		if (green.curr_state == Kitchen_State.getInstance ()) {
			Debug.Log (green.name + "Kitchen State");
			MoveTo (kitchen.transform.position);
		} else {
			//Debug.Log (abe.name + "Not in kitchen");
		}
	}

	void OnMouseDown() {
		ElderlyGreenSpeechBubble.Inst.Appear ();
	}
	
}

