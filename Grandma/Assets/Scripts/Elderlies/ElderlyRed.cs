using UnityEngine;
using System.Collections;

public class ElderlyRed : ElderlyBase {
	/*
	private static ElderlyRed _inst;
	public static ElderlyRed Inst { get { return _inst; } }

	void Awake()
	{
		
		_inst = this;
		
	}*/
	public AudioSource talk;

	void Start()
	{
		npc = new NPC("Edgar");
		npc.thresholds = new Threshold(22, 59, 21, 80, 20, 80, 19, 88, 25, 75, 30, 66);
		//Debug.Log ("***********DONT IGnORE ME **********");
	}

	void OnMouseDown() {
		ElderlyRedSpeechBubble.Inst.Appear ();
		talk.Play ();
	}

}
