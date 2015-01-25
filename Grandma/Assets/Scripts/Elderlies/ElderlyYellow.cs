using UnityEngine;
using System.Collections;

public class ElderlyYellow: ElderlyBase {
	/*
	private static ElderlyYellow _inst;
	public static ElderlyYellow Inst { get { return _inst; } }

	void Awake()
	{
		
		_inst = this;
		
	}*/
	public AudioSource talk;

	void Start()
	{
		npc = new NPC("Susie");
		npc.thresholds = new Threshold(20, 47, 19, 45, 85, 60, 15, 70, 30, 60, 24, 64);
		//Debug.Log ("***********DONT IGnORE ME **********");
	}

	void OnMouseDown() {
		ElderlyYellowSpeechBubble.Inst.Appear ();
		talk.Play ();
	}
	
}
