
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
    void _State.enter(NPC character)
		{
            System.Console.WriteLine(character.name + " Entering wander state.");
		}


    void _State.execute(NPC character)
		{
            System.Console.WriteLine(character.name + " is wandering");
            if (World.getInstance().isNight())
            {
                character.ChangeState(GoToSleep_State.getInstance());
            }
            else if (World.getInstance().getRandom() < Constants.BACK_FROM_ODD_CHANCE)
            {
                character.ChangeState(Decision_State.getInstance());
            }

		}


        void _State.exit(NPC character)
		{
            System.Console.WriteLine(character.name + " Exiting wander state.");
		
		}
        
    //-------------------------------------------
    private static _State instance;

    }

