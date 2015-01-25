using UnityEngine;
using System.Collections;

public class Elderly1SpeechBubble : SpeechBubbleBase {

	private static Elderly1SpeechBubble _inst;
	public static Elderly1SpeechBubble Inst { get { return _inst; } }

	void Awake()
	{
		
		_inst = this;
		
	}


}
