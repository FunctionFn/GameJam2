using UnityEngine;
using System.Collections;

public class ElderlyBlue : ElderlyBase {
	
	private static ElderlyBlue _inst;
	public static ElderlyBlue Inst { get { return _inst; } }
	
	void OnMouseDown() {
		ElderlyBlueSpeechBubble.Inst.Appear ();
	}
	
}
