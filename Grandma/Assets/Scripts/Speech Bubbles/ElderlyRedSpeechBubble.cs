using UnityEngine;
using System.Collections;

public class ElderlyRedSpeechBubble : SpeechBubbleBase {

	private static ElderlyRedSpeechBubble _inst;
	public static ElderlyRedSpeechBubble Inst { get { return _inst; } }

	void Awake()
	{
		
		_inst = this;
		
	}


}
