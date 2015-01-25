using UnityEngine;
using System.Collections;

public class ElderlyBlue : ElderlyBase {
	/*
	private static ElderlyBlue _inst;
	public static ElderlyBlue Inst { get { return _inst; } }

	void Awake()
	{
		
		_inst = this;
		
	}*/

	void Start()
	{
		npc = new NPC("Ethel");
		npc.thresholds = new Threshold(15, 77, 20, 68, 19, 88, 25, 75, 19, 88, 25, 75);
		//Debug.Log ("***********DONT IGnORE ME **********");
	}
	void OnMouseDown() {
		ElderlyBlueSpeechBubble.Inst.Appear ();
	}
	
}
