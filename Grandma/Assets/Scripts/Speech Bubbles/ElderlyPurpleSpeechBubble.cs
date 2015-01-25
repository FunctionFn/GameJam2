using UnityEngine;
using System.Collections;

public class ElderlyPurpleSpeechBubble : SpeechBubbleBase {
	
	private static ElderlyPurpleSpeechBubble _inst;
	public static ElderlyPurpleSpeechBubble Inst { get { return _inst; } }
	
	void Awake()
	{
		
		_inst = this;
		
	}
	
	
}
