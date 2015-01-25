using UnityEngine;
using System.Collections;

public class ElderlyRed : ElderlyBase {

	private static ElderlyRed _inst;
	public static ElderlyRed Inst { get { return _inst; } }

	void OnMouseDown() {
		ElderlyRedSpeechBubble.Inst.Appear ();
	}

}
