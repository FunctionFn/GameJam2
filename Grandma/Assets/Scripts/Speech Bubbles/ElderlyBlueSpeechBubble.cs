using UnityEngine;
using System.Collections;

public class ElderlyBlueSpeechBubble : SpeechBubbleBase {
	
	private static ElderlyBlueSpeechBubble _inst;
	public static ElderlyBlueSpeechBubble Inst { get { return _inst; } }
	
	void Awake()
	{
		
		_inst = this;
		
	}
	
	
}