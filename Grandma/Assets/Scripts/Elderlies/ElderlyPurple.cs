using UnityEngine;
using System.Collections;

public class ElderlyPurple : ElderlyBase {
	
	private static ElderlyPurple _inst;
	public static ElderlyPurple Inst { get { return _inst; } }
	
	void OnMouseDown() {
		ElderlyPurpleSpeechBubble.Inst.Appear ();
	}
	
}
