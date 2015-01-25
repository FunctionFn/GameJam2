public class GoToKitchen_State: _State
{
    private GoToKitchen_State()
    {
    }

    public static _State getInstance()
    {
        if (instance == null)
        {
            instance = new GoToKitchen_State();
        }

        return instance;
    }

    void _State.enter(NPC character)
    {
        Console.Write(character.name + "is going to the Kitchen");
    }

    void _State.execute(NPC character)
    {
        // BasicPath.move(room)
        Console.Write(character.name + ": the food here tastes like cardboard");
        if (World.getInstance().isNight())
        {
            character.ChangeState(GoToSleep_State.getInstance());
        }
        else
        {
            character.ChangeState(Kitchen_State.getInstance());
        }
    }

    void _State.exit(NPC character)
    {
        Console.Write(character.name + "is arriving in the kitchen");
    }

    //-------------------------------------------
    private static _State instance;

}

