using UnityEngine;
using System.Collections;

public class ElderlyGreenSpeechBubble : SpeechBubbleBase {
	
	private static ElderlyGreenSpeechBubble _inst;
	public static ElderlyGreenSpeechBubble Inst { get { return _inst; } }


	void Awake()
	{
		
		_inst = this;
		
	}


}
