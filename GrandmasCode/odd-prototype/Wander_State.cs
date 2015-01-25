
public class Wander_State: _State
    {
	
	    private Wander_State()
    {
    }

    public static _State getInstance()
    {
        if (instance == null)
        {
            instance = new Wander_State();
        }

        return instance;
    }
        void enter(NPC character)
		{
			System.Console.WriteLine("Entering wander state.");
		}
        
	
        void execute(NPC character)
		{

		Random stopRandom = new Random ();
				// begin executing wander
		// randomly stay wandering
		// if state changes, go back to decision
		character.ChangeState(Decision_State.getInstance());
		// if night happens before loop exits, break loop and go back to room
		character.ChangeState(Sleep_State.getInstance());

		}


        void exit(NPC character)
		{
		System.Console.WriteLine("Exiting wander state.");
		
		}
        
    //-------------------------------------------
    private static _State instance;

    }

