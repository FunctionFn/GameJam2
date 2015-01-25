
public class GoToPT_State : _State
{
    private GoToPT_State()
    {
    }

    public static _State getInstance()
    {
        if (instance == null)
        {
            instance = new GoToPT_State();
        }

        return instance;
    }

    void _State.enter(NPC character)
    {
        System.Console.WriteLine(character.name + "is going to the physical therapy");
        character.isWalking = true;
    }

    void _State.execute(NPC character)
    {
        // BasicPath.move(room)
        System.Console.WriteLine(character.name + ": i feel stiff as a board.  but i hate my physical therapy");
        if (World.getInstance().isNight())
        {
            character.ChangeState(GoToSleep_State.getInstance());
        }
        else if (!character.isWalking && PTRoom.getInstance().canEnter())
        {
            character.ChangeState(PT_State.getInstance());
        }
        else if (!character.isWalking && !PTRoom.getInstance().canEnter())
        {
            character.ChangeState(Decision_State.getInstance());
        }
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + "is arriving in the physical therapy");
    }

    //-------------------------------------------
    private static _State instance;

}

