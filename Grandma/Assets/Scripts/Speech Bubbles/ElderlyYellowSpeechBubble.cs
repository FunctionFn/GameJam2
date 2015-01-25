using UnityEngine;
using System.Collections;

public class ElderlyYellowSpeechBubble : SpeechBubbleBase {
	
	private static ElderlyYellowSpeechBubble _inst;
	public static ElderlyYellowSpeechBubble Inst { get { return _inst; } }
	
	void Awake()
	{
		
		_inst = this;
		
	}
	
	
}