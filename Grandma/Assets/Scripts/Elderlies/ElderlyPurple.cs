using UnityEngine;
using System.Collections;

public class ElderlyPurple : ElderlyBase {
	
	/*private static ElderlyPurple _inst;
	public static ElderlyPurple Inst { get { return _inst; } }

	void Awake()
	{
		
		_inst = this;
		
	}*/

	void Start()
	{
		npc = new NPC("Joe");
		npc.thresholds = new Threshold(19, 88, 25, 75, 30, 66, 15, 80, 50, 80, 20, 80);
		//Debug.Log ("***********DONT IGnORE ME **********");
	}


	void OnMouseDown() {
		ElderlyPurpleSpeechBubble.Inst.Appear ();
	}
	
}
