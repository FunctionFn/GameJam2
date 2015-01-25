using UnityEngine;
using System.Collections;

public class Elderly1 : ElderlyBase {

	void OnMouseDown() {
		Elderly1SpeechBubble.Inst.Appear ();
	}

}
