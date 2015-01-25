
public class Nap_State: _State
    {
	
	    private Nap_State()
    {
    }

    public static _State getInstance()
    {
        if (instance == null)
        {
            instance = new Nap_State();
        }

        return instance;
    }
        void enter(NPC character)
		{
			System.Console.WriteLine("Entering nap state.");
		}
        
	
        void execute(NPC character)
		{

		Random stopRandom = new Random ();
		
		// begin executing nap
		// randomly stay a nap
		// if state changes, go back to decision
		character.ChangeState(Decision_State.getInstance());
		// if night happens go back to room
		character.ChangeState(Sleep_State.getInstance());

		}


        void exit(NPC character)
		{
		System.Console.WriteLine("Exiting nap state.");
		}
        
    //-------------------------------------------
    private static _State instance;

    }

