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
        System.Console.WriteLine(character.name + " decided to go to the Kitchen");
        character.isWalking = true;
    }

    void _State.execute(NPC character)
    {
        // BasicPath.move(room)
        System.Console.WriteLine(character.name + ": the food here tastes like cardboard");
        if (World.getInstance().isNight())
        {
            character.ChangeState(GoToSleep_State.getInstance());
        }
        else if (!character.isWalking && KitchenRoom.getInstance().canEnter())
        {
            character.ChangeState(Kitchen_State.getInstance());
        }
        else if (!character.isWalking && !KitchenRoom.getInstance().canEnter())
        {
            character.ChangeState(Decision_State.getInstance());
        }
    }

    void _State.exit(NPC character)
    {
        System.Console.WriteLine(character.name + " is arriving in the kitchen");
    }

    //-------------------------------------------
    private static _State instance;

}

