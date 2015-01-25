using UnityEngine;
using System.Collections;

public class ElderlyYellow: ElderlyBase {
	
	private static ElderlyYellow _inst;
	public static ElderlyYellow Inst { get { return _inst; } }
	
	void OnMouseDown() {
		ElderlyYellowSpeechBubble.Inst.Appear ();
	}
	
}
