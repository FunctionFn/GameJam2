
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
    void _State.enter(NPC character)
		{
			System.Console.WriteLine(character.name + " Entering reminisce state.");
		}


    void _State.execute(NPC character)
		{
            System.Console.WriteLine(character.name + " is reminiscing");
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
            System.Console.WriteLine(character.name + " Exiting reminisce state.");
		
		}
        
    //-------------------------------------------
    private static _State instance;

    }

