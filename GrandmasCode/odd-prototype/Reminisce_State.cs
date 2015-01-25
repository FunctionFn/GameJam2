
public class Reminisce_State: _State
    {
	
	    private Reminisce_State()
    {
    }

    public static _State getInstance()
    {
        if (instance == null)
        {
            instance = new Reminisce_State();
        }

        return instance;
    }
        void enter(NPC character)
		{
			System.Console.WriteLine("Entering reminisce state.");
		}
        
	
        void execute(NPC character)
		{

		Random stopRandom = new Random ();

		
		// begin executing reminiscence 
		// randomly continue reminiscing 
		// if state changes, go back to decision
		character.ChangeState(Decision_State.getInstance());
		// if night happens go back to room
		character.ChangeState(Sleep_State.getInstance());

		}


        void exit(NPC character)
		{
		System.Console.WriteLine("Exiting reminisce state.");
		
		}
        
    //-------------------------------------------
    private static _State instance;

    }

