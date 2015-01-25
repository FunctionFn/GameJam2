
public class GoToGarden_State : _State
{
    private GoToGarden_State()
    {
    }

    public static _State getInstance()
    {
        if (instance == null)
        {
            instance = new GoToGarden_State();
        }

        return instance;
    }

    void _State.enter(NPC character)
    {
        System.Console.WriteLine(character.name + "is going to the Garden");
    }

    void _State.execute(NPC character)
    {
        // BasicPath.move(room)
        System.Console.WriteLine(character.name + ": there's nothing to do in here!  im playin shuffleboard");
        if (World.getInstance().isNight())
        {
            character.ChangeState(GoToSleep_State.getInstance());
        }
        else
        {
            character.ChangeState(Garden_State.getInstance());
        }
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + "is arriving in the Garden");
    }

    //-------------------------------------------
    private static _State instance;

}

