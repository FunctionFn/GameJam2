using UnityEngine;
using System.Collections;

public class ElderlyGreen : ElderlyBase {
	
	private static ElderlyGreen _inst;
	public static ElderlyGreen Inst { get { return _inst; } }
	
	void OnMouseDown() {
		ElderlyGreenSpeechBubble.Inst.Appear ();
	}
	
}

