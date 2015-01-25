
public class Kill_State: _State
{
	private Kill_State()
	{
	}
	
	public static _State getInstance()
	{
		if (instance == null)
		{
			instance = new Kill_State();
		}
		
		return instance;
	}
	
	void _State.enter(NPC character)
	{
		World.getInstance ().reportDeath (); //decrement global population
		System.Console.WriteLine(character.name + " died.");
		if (World.getInstance ().getElderlyLeft <= 0) 
			{
			//END THE WHOLE DAMN GAME
			}
	}
	
	void _State.execute(NPC character)
	{
		//leave empty
	}
	
	void _State.exit(NPC character)
	{
		//leave empty
	}
	
	//-------------------------------------------
	private static _State instance;


}
